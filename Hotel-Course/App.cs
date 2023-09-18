using System.Runtime.CompilerServices;

namespace Hotel_Course
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            FillSelectComboInstant();
        }

        void FillSelectComboInstant()
        {
            string numberItem(Models.Number number)
            {
                Dictionary<string, string> defineType = new Dictionary<string, string>()
                {
                    { "Luxe", "Люкс" },
                    { "SemiLuxe", "Полулюкс" },
                    { "SingleRoom", "Однокомнатный" },
                    { "DoubleRoom", "Двукомнатный" },
                    { "RoomWithSofa", "Двукомнатный с диванами" }
                };

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

            comboBoxInstantNumber.Items.Clear();
            Storage.Numbers.ForEach(n => comboBoxInstantNumber.Items.Add(numberItem(n)));
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
    }
}