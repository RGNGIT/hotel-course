using Hotel_Course.Models;

namespace Hotel_Course
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            FillSelectComboInstant();
            FillSelectNumbersGrid();
            CollectInformation();
        }

        readonly int luxeAmount = Storage.Numbers.Where(n => n is Luxe).Count();
        readonly int semiLuxeAmount = Storage.Numbers.Where(n => n is SemiLuxe).Count();
        readonly int singleRoomAmount = Storage.Numbers.Where(n => n is SingleRoom).Count();
        readonly int doubleRoomAmount = Storage.Numbers.Where(n => n is DoubleRoom).Count();
        readonly int roomWithSofaAmount = Storage.Numbers.Where(n => n is RoomWithSofa).Count();

        int closedShifts = 0;

        static int CalculatePercent(int i, int j) => (int)((float)(i / j) * 100);

        void CollectInformation()
        {
            labelStats.Text =
                $"Закрытых заявок: {closedShifts}\n" +
                $"Номера люкс {Storage.Numbers.Where(n => n is Luxe && !n.Taken).Count()} из {luxeAmount} доступно ({CalculatePercent(Storage.Numbers.Where(n => n is Luxe && !n.Taken).Count(), luxeAmount)}%)\n" +
                $"Номера полулюкс {Storage.Numbers.Where(n => n is SemiLuxe && !n.Taken).Count()} из {semiLuxeAmount} доступно ({CalculatePercent(Storage.Numbers.Where(n => n is SemiLuxe && !n.Taken).Count(), semiLuxeAmount)}%)\n" +
                $"Номера однокомнатные {Storage.Numbers.Where(n => n is SingleRoom && !n.Taken).Count()} из {singleRoomAmount} доступно ({CalculatePercent(Storage.Numbers.Where(n => n is SingleRoom && !n.Taken).Count(), singleRoomAmount)}%)\n" +
                $"Номера двукомнатные {Storage.Numbers.Where(n => n is DoubleRoom && !n.Taken).Count()} из {doubleRoomAmount} доступно ({CalculatePercent(Storage.Numbers.Where(n => n is DoubleRoom && !n.Taken).Count(), doubleRoomAmount)}%)\n" +
                $"Номера двукомнатные с диваном {Storage.Numbers.Where(n => n is RoomWithSofa && !n.Taken).Count()} из {roomWithSofaAmount} доступно ({CalculatePercent(Storage.Numbers.Where(n => n is RoomWithSofa && !n.Taken).Count(), roomWithSofaAmount)}%)";
        }

        readonly Dictionary<string, string> defineType = new()
        {
            { "Luxe", "Люкс" },
            { "SemiLuxe", "Полулюкс" },
            { "SingleRoom", "Однокомнатный" },
            { "DoubleRoom", "Двукомнатный" },
            { "RoomWithSofa", "Двукомнатный с диванами" }
        };

        string DefineNumberDetails(Models.Number number)
        {
            string typeOf = defineType[number.GetType().Name];
            string temp = $"Номер {typeOf}. Стоимость {number.Cost}р. ";

            return typeOf switch
            {
                "Люкс" => temp + $"Количество ванных комнат: {((Models.Luxe)number).AmountOfBathrooms}",
                "Полулюкс" => temp + $"Дополнительно: {((Models.SemiLuxe)number).SemiLuxeAddings}",
                "Однокомнатный" => temp + $"Количество кроватей: {((Models.SingleRoom)number).AmountOfBeds}",
                "Двукомнатный" => temp + $"Количество кроватей: {((Models.DoubleRoom)number).AmountOfBeds}",
                "Двукомнатный с диванами" => temp + $"Количество диванов: {((Models.RoomWithSofa)number).NumberOfSofas}",
                _ => "Невозможно определить",
            };
        }

        void FillSelectNumbersGrid()
        {
            dataGridViewNumbers.Rows.Clear();

            int i = 0;
            foreach (var n in Storage.Numbers)
            {
                if (!n.Taken)
                    dataGridViewNumbers.Rows.Add(i, defineType[n.GetType().Name], n.Cost, DefineNumberDetails(n), "Нет");

                i++;
            }
        }

        void FillSelectComboInstant()
        {
            comboBoxInstantNumber.Items.Clear();
            comboBoxInstantNumber.Text = string.Empty;

            int i = 0;
            foreach (var n in Storage.Numbers)
            {
                if (!n.Taken)
                    comboBoxInstantNumber.Items.Add(i + " " + DefineNumberDetails(n));

                i++;
            }
        }

        void CheckClosedRequests()
        {
            dataGridViewClosedRequests.Rows.Clear();

            List<Request> expired = Storage.Requests
                .Where(r => r.dateTo <= dateTimePickerCurrentDate.Value)
                .ToList();

            Storage.ClosedRequests = expired;
            closedShifts = expired.Count;

            foreach (var req in Storage.ClosedRequests)
            {
                float countPrice(Request request) 
                {
                    if (request is InstantRequest ir)
                        return ir.discountApplied != 0 ? ir.Number.Cost * ((float)ir.discountApplied / 100) : ir.Number.Cost;

                    if(request is BulkRequest br) 
                    {
                        float costSum = 0;

                        for(int i = 0; i < br.Numbers.Count; i++) 
                        {
                            if (br.DiscountMap![i] != 0) 
                            {
                                costSum += br.Numbers[i].Cost * ((float)br.DiscountMap![i] / 100);
                            }
                            else
                            {
                                costSum += br.Numbers[i].Cost;
                            }
                        }
                    }

                    return 1234;
                }

                // Storage.Requests.Remove(req);

                if (req is InstantRequest ir)
                    Storage.Numbers
                        .First(n => n.Id == ir.Number.Id).Taken = false;

                if (req is BulkRequest br)
                    br.Numbers
                        .ForEach(n => Storage.Numbers.First(sn => sn.Id == n.Id).Taken = false);

                dataGridViewClosedRequests.Rows.Add(
                    req.Id,
                    req.Holder,
                    req.dateFrom,
                    req.dateTo,
                    countPrice(req)
                    );
            }

            FillSelectComboInstant();
            FillSelectNumbersGrid();
            FillRegisteredRequestsGrid();
        }

        private void buttonAddDay_Click(object sender, EventArgs e)
        {
            dateTimePickerCurrentDate.Value = dateTimePickerCurrentDate.Value.AddDays(1);

            CheckClosedRequests();
            CollectInformation();
        }

        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Забронировать выбранный(е) номера?", "Бронь", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                return;

            if (dateTimePickerRequestFrom.Value < dateTimePickerCurrentDate.Value)
            {
                MessageBox.Show("Невозможно установить дату заезда задним числом");
                return;
            }

            switch (tabControl2.SelectedIndex)
            {
                case 0:
                    Request requestInstant = new InstantRequest(
                        Guid.NewGuid().ToString(),
                        textBoxRequestHolder.Text,
                        Storage.Numbers.ElementAt(int.Parse(comboBoxInstantNumber.Text.Split(' ')[0])),
                        dateTimePickerRequestFrom.Value,
                        dateTimePickerRequestTo.Value
                        );

                    if (comboBoxInstantNumber.Text.Contains("Скидка"))
                    {
                        int discount = int.Parse(comboBoxInstantNumber.Text.Split("Скидка")[1].Split(' ')[1]);
                        ((InstantRequest)requestInstant).discountApplied = discount;
                    }

                    Storage.Requests.Add(requestInstant);
                    Storage.Numbers.ElementAt(int.Parse(comboBoxInstantNumber.Text.Split(' ')[0])).Taken = true;
                    break;
                case 1:
                    List<Number> numbers = new();
                    List<int> discountMap = new();

                    foreach (DataGridViewRow select in dataGridViewNumbers.SelectedRows)
                    {
                        numbers.Add(Storage.Numbers.ElementAt(int.Parse(select.Cells[0].Value.ToString()!)));

                        if (select.Cells[4].Value.ToString() != "Нет")
                        {
                            discountMap.Add(int.Parse(select.Cells[4].Value.ToString()!));
                        }
                        else
                        {
                            discountMap.Add(0);
                        }

                        Storage.Numbers.ElementAt(int.Parse(select.Cells[0].Value.ToString()!)).Taken = true;
                    }

                    Request requestBulk = new BulkRequest(
                        Guid.NewGuid().ToString(),
                        textBoxRequestHolder.Text,
                        numbers,
                        dateTimePickerRequestFrom.Value,
                        dateTimePickerRequestTo.Value
                        );

                    ((BulkRequest)requestBulk).DiscountMap = discountMap;

                    Storage.Requests.Add(requestBulk);
                    break;
            }

            FillSelectComboInstant();
            FillSelectNumbersGrid();
            CollectInformation();
        }

        private void tabControl2_TabIndexChanged(object sender, EventArgs e)
        {
            FillSelectComboInstant();
            FillSelectNumbersGrid();
        }

        void FillRegisteredRequestsGrid()
        {
            dataGridViewRegisteredRequests.Rows.Clear();

            foreach (Request request in Storage.Requests)
            {
                if(!Storage.ClosedRequests.Contains(request))
                switch (request.GetType().Name)
                {
                    case "InstantRequest":
                        dataGridViewRegisteredRequests.Rows.Add(
                            request.Id,
                            request.Holder,
                            request.dateFrom,
                            request.dateTo,
                            DefineNumberDetails(((InstantRequest)request).Number),
                            ((InstantRequest)request).discountApplied != 0 ? ((InstantRequest)request).discountApplied : "Нет"
                            );
                        break;
                    case "BulkRequest":
                        int i = 0;
                        foreach (Number number in ((BulkRequest)request).Numbers)
                        {
                            dataGridViewRegisteredRequests.Rows.Add(
                                request.Id,
                                request.Holder,
                                request.dateFrom,
                                request.dateTo,
                                DefineNumberDetails(number),
                                ((BulkRequest)request).DiscountMap!.ElementAt(i) != 0 ? ((BulkRequest)request).DiscountMap!.ElementAt(i) : "Нет"
                                );

                            i++;
                        }
                        break;
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillRegisteredRequestsGrid();
        }

        private void comboBoxRoomTypeRequired_SelectedValueChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> defineType = new()
            {
                { "Люкс", "Luxe" },
                { "Полулюкс", "SemiLuxe" },
                { "Однокомнатный", "SingleRoom" },
                { "Двукомнатный", "DoubleRoom" },
                { "Двукомнатный с диванами", "RoomWithSofa" }
            };

            string? discountCalculation(string initialRoomName)
            {
                Dictionary<string, int> numberTier = new()
                {
                    { "SingleRoom", 0 },
                    { "DoubleRoom", 1 },
                    { "RoomWithSofa", 2 },
                    { "SemiLuxe", 3 },
                    { "Luxe", 4 }
                };

                int tierToDiscount = numberTier[initialRoomName] + 1;

                if (tierToDiscount <= numberTier.ElementAt(numberTier.Count - 1).Value)
                {
                    return numberTier.ElementAt(tierToDiscount).Key;
                }

                return null;
            }

            List<Number> numbersRequired = Storage.Numbers
                .Where(n => n.GetType().Name == defineType[comboBoxRoomTypeRequired.Text] && !n.Taken)
                .ToList();

            if (numbersRequired == null || numbersRequired.Count == 0)
            {
                MessageBox.Show("Желаемой комнаты не найдено. Применены скидочные политики.");
                string? discount = discountCalculation(defineType[comboBoxRoomTypeRequired.Text]);

                switch (tabControl2.SelectedIndex)
                {
                    case 0:
                    case 1:
                        int i = 0;
                        foreach (var n in comboBoxInstantNumber.Items)
                        {
                            if (Storage.Numbers.ElementAt(int.Parse(n.ToString()!.Split(' ')[0])).GetType().Name == discount)
                            {
                                comboBoxInstantNumber.Items[i] = n.ToString() + $" (Скидка {70} %)";
                            }

                            i++;
                        }

                        for (int j = 0; j < dataGridViewNumbers.Rows.Count - 1; j++)
                        {
                            if (Storage.Numbers.ElementAt(int.Parse(dataGridViewNumbers.Rows[j].Cells[0].Value.ToString()!)).GetType().Name == discount)
                            {
                                dataGridViewNumbers.Rows[j].Cells[4].Value = $"{70} %";
                            }
                        }

                        break;
                }
            }
        }
    }
}