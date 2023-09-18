namespace Hotel_Course
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonAddRequest = new Button();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            labelDescriptionInstant = new Label();
            label5 = new Label();
            comboBoxInstantNumber = new ComboBox();
            tabPage4 = new TabPage();
            dataGridViewNumbers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            textBoxRequestHolder = new TextBox();
            dateTimePickerRequestFrom = new DateTimePicker();
            dateTimePickerRequestTo = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            buttonAddDay = new Button();
            label1 = new Label();
            dateTimePickerCurrentDate = new DateTimePicker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumbers).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 446);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonAddRequest);
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Controls.Add(textBoxRequestHolder);
            tabPage1.Controls.Add(dateTimePickerRequestFrom);
            tabPage1.Controls.Add(dateTimePickerRequestTo);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 418);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Заявка";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAddRequest
            // 
            buttonAddRequest.Location = new Point(6, 385);
            buttonAddRequest.Name = "buttonAddRequest";
            buttonAddRequest.Size = new Size(200, 23);
            buttonAddRequest.TabIndex = 9;
            buttonAddRequest.Text = "Оставить заявку";
            buttonAddRequest.UseVisualStyleBackColor = true;
            buttonAddRequest.Click += buttonAddRequest_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(212, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(574, 409);
            tabControl2.TabIndex = 0;
            tabControl2.TabIndexChanged += tabControl2_TabIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(labelDescriptionInstant);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(comboBoxInstantNumber);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(566, 381);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Заселиться в текущий момент";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelDescriptionInstant
            // 
            labelDescriptionInstant.AutoSize = true;
            labelDescriptionInstant.Location = new Point(212, 47);
            labelDescriptionInstant.Name = "labelDescriptionInstant";
            labelDescriptionInstant.Size = new Size(0, 15);
            labelDescriptionInstant.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 3);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 7;
            label5.Text = "Номер";
            // 
            // comboBoxInstantNumber
            // 
            comboBoxInstantNumber.FormattingEnabled = true;
            comboBoxInstantNumber.Location = new Point(6, 21);
            comboBoxInstantNumber.Name = "comboBoxInstantNumber";
            comboBoxInstantNumber.Size = new Size(554, 23);
            comboBoxInstantNumber.TabIndex = 6;
            comboBoxInstantNumber.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridViewNumbers);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(566, 381);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Забронировать номера на определенный срок";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNumbers
            // 
            dataGridViewNumbers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNumbers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewNumbers.Location = new Point(6, 6);
            dataGridViewNumbers.Name = "dataGridViewNumbers";
            dataGridViewNumbers.RowTemplate.Height = 25;
            dataGridViewNumbers.Size = new Size(554, 369);
            dataGridViewNumbers.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Номер";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Стоимость";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Доп. инфо.";
            Column3.Name = "Column3";
            // 
            // textBoxRequestHolder
            // 
            textBoxRequestHolder.Location = new Point(6, 27);
            textBoxRequestHolder.Name = "textBoxRequestHolder";
            textBoxRequestHolder.Size = new Size(200, 23);
            textBoxRequestHolder.TabIndex = 3;
            // 
            // dateTimePickerRequestFrom
            // 
            dateTimePickerRequestFrom.Location = new Point(6, 71);
            dateTimePickerRequestFrom.Name = "dateTimePickerRequestFrom";
            dateTimePickerRequestFrom.Size = new Size(200, 23);
            dateTimePickerRequestFrom.TabIndex = 0;
            // 
            // dateTimePickerRequestTo
            // 
            dateTimePickerRequestTo.Location = new Point(6, 115);
            dateTimePickerRequestTo.Name = "dateTimePickerRequestTo";
            dateTimePickerRequestTo.Size = new Size(200, 23);
            dateTimePickerRequestTo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 97);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 5;
            label4.Text = "Дата выезда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Держатель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 53);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Дата заезда";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonAddDay);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dateTimePickerCurrentDate);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 418);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Управление временем";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddDay
            // 
            buttonAddDay.Location = new Point(6, 50);
            buttonAddDay.Name = "buttonAddDay";
            buttonAddDay.Size = new Size(162, 23);
            buttonAddDay.TabIndex = 2;
            buttonAddDay.Text = "+ День";
            buttonAddDay.UseVisualStyleBackColor = true;
            buttonAddDay.Click += buttonAddDay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Текущая дата";
            // 
            // dateTimePickerCurrentDate
            // 
            dateTimePickerCurrentDate.Location = new Point(6, 21);
            dateTimePickerCurrentDate.Name = "dateTimePickerCurrentDate";
            dateTimePickerCurrentDate.Size = new Size(162, 23);
            dateTimePickerCurrentDate.TabIndex = 0;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "App";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumbers).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label1;
        private DateTimePicker dateTimePickerCurrentDate;
        private Button buttonAddDay;
        private Label label5;
        private ComboBox comboBoxInstantNumber;
        private Label label4;
        private Label label3;
        private TextBox textBoxRequestHolder;
        private Label label2;
        private DateTimePicker dateTimePickerRequestTo;
        private DateTimePicker dateTimePickerRequestFrom;
        private Label labelDescriptionInstant;
        private Button buttonAddRequest;
        private DataGridView dataGridViewNumbers;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}