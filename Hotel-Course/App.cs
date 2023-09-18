using System.Runtime.CompilerServices;

namespace Hotel_Course
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            FillSelectComboInstant();
            FillSelectNumbersGrid();
        }

        Dictionary<string, string> defineType = new Dictionary<string, string>()
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

            switch (typeOf)
            {
                case "Люкс":
                    return temp + $"Количество ванных комнат: {((Models.Luxe)number).AmountOfBathrooms}";

                case "Полулюкс":
                    return temp + $"Дополнительно: {((Models.SemiLuxe)number).SemiLuxeAddings}";

                case "Однокомнатный":
                    return temp + $"Количество кроватей: {((Models.SingleRoom)number).AmountOfBeds}";

                case "Двукомнатный":
                    return temp + $"Количество кроватей: {((Models.DoubleRoom)number).AmountOfBeds}";

                case "Двукомнатный с диванами":
                    return temp + $"Количество диванов: {((Models.RoomWithSofa)number).NumberOfSofas}";
            }

            return "Невозможно определить";
        }

        void FillSelectNumbersGrid()
        {
            dataGridViewNumbers.Rows.Clear();

            Storage.Numbers.ForEach(n => dataGridViewNumbers.Rows.Add(defineType[n.GetType().Name], n.Cost, DefineNumberDetails(n)));
        }

        void FillSelectComboInstant()
        {
            comboBoxInstantNumber.Items.Clear();

            Storage.Numbers.ForEach(n => comboBoxInstantNumber.Items.Add(DefineNumberDetails(n)));
        }

        private void buttonAddDay_Click(object sender, EventArgs e)
        {
            dateTimePickerCurrentDate.Value = dateTimePickerCurrentDate.Value.AddDays(1);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddRequest_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_TabIndexChanged(object sender, EventArgs e)
        {
            FillSelectComboInstant();
            FillSelectNumbersGrid();
        }
    }
}