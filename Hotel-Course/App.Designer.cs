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
            label6 = new Label();
            comboBoxRoomTypeRequired = new ComboBox();
            buttonAddRequest = new Button();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            labelDescriptionInstant = new Label();
            label5 = new Label();
            comboBoxInstantNumber = new ComboBox();
            tabPage4 = new TabPage();
            dataGridViewNumbers = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            textBoxRequestHolder = new TextBox();
            dateTimePickerRequestFrom = new DateTimePicker();
            dateTimePickerRequestTo = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabPage5 = new TabPage();
            dataGridViewRegisteredRequests = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            tabPage7 = new TabPage();
            dataGridViewClosedRequests = new DataGridView();
            tabPage6 = new TabPage();
            labelStats = new Label();
            tabPage2 = new TabPage();
            buttonAddDay = new Button();
            label1 = new Label();
            dateTimePickerCurrentDate = new DateTimePicker();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumbers).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegisteredRequests).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClosedRequests).BeginInit();
            tabPage6.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 446);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(comboBoxRoomTypeRequired);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 141);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 11;
            label6.Text = "Желаемая комната";
            // 
            // comboBoxRoomTypeRequired
            // 
            comboBoxRoomTypeRequired.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomTypeRequired.FormattingEnabled = true;
            comboBoxRoomTypeRequired.Items.AddRange(new object[] { "Люкс", "Полулюкс", "Однокомнатный", "Двукомнатный", "Двукомнатный с диванами" });
            comboBoxRoomTypeRequired.Location = new Point(6, 159);
            comboBoxRoomTypeRequired.Name = "comboBoxRoomTypeRequired";
            comboBoxRoomTypeRequired.Size = new Size(200, 23);
            comboBoxRoomTypeRequired.TabIndex = 10;
            comboBoxRoomTypeRequired.SelectedValueChanged += comboBoxRoomTypeRequired_SelectedValueChanged;
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
            dataGridViewNumbers.Columns.AddRange(new DataGridViewColumn[] { Column9, Column1, Column2, Column3, Column10 });
            dataGridViewNumbers.Location = new Point(6, 6);
            dataGridViewNumbers.Name = "dataGridViewNumbers";
            dataGridViewNumbers.RowTemplate.Height = 25;
            dataGridViewNumbers.Size = new Size(554, 369);
            dataGridViewNumbers.TabIndex = 0;
            // 
            // Column9
            // 
            Column9.HeaderText = "Index";
            Column9.Name = "Column9";
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
            // Column10
            // 
            Column10.HeaderText = "Скидка";
            Column10.Name = "Column10";
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
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridViewRegisteredRequests);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(789, 418);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Зарегистрированные заявки";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRegisteredRequests
            // 
            dataGridViewRegisteredRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRegisteredRequests.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6, Column7, Column8, Column11 });
            dataGridViewRegisteredRequests.Location = new Point(6, 6);
            dataGridViewRegisteredRequests.Name = "dataGridViewRegisteredRequests";
            dataGridViewRegisteredRequests.RowTemplate.Height = 25;
            dataGridViewRegisteredRequests.Size = new Size(776, 406);
            dataGridViewRegisteredRequests.TabIndex = 0;
            // 
            // Column4
            // 
            Column4.HeaderText = "Id";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Держатель";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Дата заезда";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Дата выезда";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Детали";
            Column8.Name = "Column8";
            // 
            // Column11
            // 
            Column11.HeaderText = "Скидка";
            Column11.Name = "Column11";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(dataGridViewClosedRequests);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(789, 418);
            tabPage7.TabIndex = 4;
            tabPage7.Text = "Закрытые заявки";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClosedRequests
            // 
            dataGridViewClosedRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClosedRequests.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column12 });
            dataGridViewClosedRequests.Location = new Point(6, 6);
            dataGridViewClosedRequests.Name = "dataGridViewClosedRequests";
            dataGridViewClosedRequests.RowTemplate.Height = 25;
            dataGridViewClosedRequests.Size = new Size(776, 406);
            dataGridViewClosedRequests.TabIndex = 1;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(labelStats);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(789, 418);
            tabPage6.TabIndex = 3;
            tabPage6.Text = "Статистика";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // labelStats
            // 
            labelStats.AutoSize = true;
            labelStats.Location = new Point(3, 3);
            labelStats.Name = "labelStats";
            labelStats.Size = new Size(38, 15);
            labelStats.TabIndex = 0;
            labelStats.Text = "label7";
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Держатель";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Дата заезда";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Дата выезда";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column12
            // 
            Column12.HeaderText = "Стоимость";
            Column12.Name = "Column12";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "App";
            Text = "App";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumbers).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegisteredRequests).EndInit();
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClosedRequests).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
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
        private TabPage tabPage5;
        private DataGridView dataGridViewRegisteredRequests;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label6;
        private ComboBox comboBoxRoomTypeRequired;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private TabPage tabPage6;
        private Label labelStats;
        private TabPage tabPage7;
        private DataGridView dataGridViewClosedRequests;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column12;
    }
}