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
            { "Luxe", "����" },
            { "SemiLuxe", "��������" },
            { "SingleRoom", "�������������" },
            { "DoubleRoom", "������������" },
            { "RoomWithSofa", "������������ � ��������" }
        };

        string DefineNumberDetails(Models.Number number)
        {
            string typeOf = defineType[number.GetType().Name];
            string temp = $"����� {typeOf}. ��������� {number.Cost}�. ";

            switch (typeOf)
            {
                case "����":
                    return temp + $"���������� ������ ������: {((Models.Luxe)number).AmountOfBathrooms}";

                case "��������":
                    return temp + $"�������������: {((Models.SemiLuxe)number).SemiLuxeAddings}";

                case "�������������":
                    return temp + $"���������� ��������: {((Models.SingleRoom)number).AmountOfBeds}";

                case "������������":
                    return temp + $"���������� ��������: {((Models.DoubleRoom)number).AmountOfBeds}";

                case "������������ � ��������":
                    return temp + $"���������� �������: {((Models.RoomWithSofa)number).NumberOfSofas}";
            }

            return "���������� ����������";
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