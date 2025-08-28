namespace EmployeeInformation
{
    partial class Form1
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
            buttonEmployeeInformation = new Button();
            buttonStatistics = new Button();
            dataGridView = new DataGridView();
            buttonFilter = new Button();
            textBoxLastName = new TextBox();
            buttonSort = new Button();
            panelFilter = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxPost = new ComboBox();
            comboBoxDep = new ComboBox();
            comboBoxStatus = new ComboBox();
            panelSort = new Panel();
            rBDateUneploy = new RadioButton();
            rBDateEmploy = new RadioButton();
            rBPost = new RadioButton();
            rBDep = new RadioButton();
            rBStatus = new RadioButton();
            rBFIO = new RadioButton();
            buttonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelFilter.SuspendLayout();
            panelSort.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEmployeeInformation
            // 
            buttonEmployeeInformation.BackColor = SystemColors.Control;
            buttonEmployeeInformation.Location = new Point(12, 94);
            buttonEmployeeInformation.Name = "buttonEmployeeInformation";
            buttonEmployeeInformation.Size = new Size(180, 56);
            buttonEmployeeInformation.TabIndex = 0;
            buttonEmployeeInformation.Text = "Вывести информацию о сотрудниках";
            buttonEmployeeInformation.UseVisualStyleBackColor = false;
            buttonEmployeeInformation.Click += buttonEmployeeInformation_Click;
            // 
            // buttonStatistics
            // 
            buttonStatistics.BackColor = SystemColors.Control;
            buttonStatistics.Location = new Point(12, 181);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(180, 56);
            buttonStatistics.TabIndex = 0;
            buttonStatistics.Text = "Вывести статистику";
            buttonStatistics.UseVisualStyleBackColor = false;
            buttonStatistics.Click += buttonStatistics_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(255, 185);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(568, 286);
            dataGridView.TabIndex = 1;
            // 
            // buttonFilter
            // 
            buttonFilter.BackColor = SystemColors.Control;
            buttonFilter.Location = new Point(841, 62);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(110, 36);
            buttonFilter.TabIndex = 0;
            buttonFilter.Text = "Фильтр";
            buttonFilter.UseVisualStyleBackColor = false;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(207, 108);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(151, 27);
            textBoxLastName.TabIndex = 2;
            // 
            // buttonSort
            // 
            buttonSort.BackColor = SystemColors.Control;
            buttonSort.Location = new Point(841, 104);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(110, 36);
            buttonSort.TabIndex = 0;
            buttonSort.Text = "Сортировка";
            buttonSort.UseVisualStyleBackColor = false;
            buttonSort.Click += buttonSort_Click;
            // 
            // panelFilter
            // 
            panelFilter.Controls.Add(label4);
            panelFilter.Controls.Add(label3);
            panelFilter.Controls.Add(label2);
            panelFilter.Controls.Add(label1);
            panelFilter.Controls.Add(comboBoxPost);
            panelFilter.Controls.Add(comboBoxDep);
            panelFilter.Controls.Add(comboBoxStatus);
            panelFilter.Controls.Add(textBoxLastName);
            panelFilter.Location = new Point(444, 21);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(379, 144);
            panelFilter.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 111);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 77);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Должность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 43);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Отдел";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Статус";
            // 
            // comboBoxPost
            // 
            comboBoxPost.FormattingEnabled = true;
            comboBoxPost.Location = new Point(207, 74);
            comboBoxPost.Name = "comboBoxPost";
            comboBoxPost.Size = new Size(151, 28);
            comboBoxPost.TabIndex = 3;
            // 
            // comboBoxDep
            // 
            comboBoxDep.FormattingEnabled = true;
            comboBoxDep.Location = new Point(207, 40);
            comboBoxDep.Name = "comboBoxDep";
            comboBoxDep.Size = new Size(151, 28);
            comboBoxDep.TabIndex = 3;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(207, 6);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 3;
            // 
            // panelSort
            // 
            panelSort.Controls.Add(rBDateUneploy);
            panelSort.Controls.Add(rBDateEmploy);
            panelSort.Controls.Add(rBPost);
            panelSort.Controls.Add(rBDep);
            panelSort.Controls.Add(rBStatus);
            panelSort.Controls.Add(rBFIO);
            panelSort.Location = new Point(841, 149);
            panelSort.Name = "panelSort";
            panelSort.Size = new Size(167, 198);
            panelSort.TabIndex = 4;
            // 
            // rBDateUneploy
            // 
            rBDateUneploy.AutoSize = true;
            rBDateUneploy.Location = new Point(11, 164);
            rBDateUneploy.Name = "rBDateUneploy";
            rBDateUneploy.Size = new Size(149, 24);
            rBDateUneploy.TabIndex = 0;
            rBDateUneploy.TabStop = true;
            rBDateUneploy.Text = "Дата увольнения";
            rBDateUneploy.UseVisualStyleBackColor = true;
            // 
            // rBDateEmploy
            // 
            rBDateEmploy.AutoSize = true;
            rBDateEmploy.Location = new Point(11, 134);
            rBDateEmploy.Name = "rBDateEmploy";
            rBDateEmploy.Size = new Size(120, 24);
            rBDateEmploy.TabIndex = 0;
            rBDateEmploy.TabStop = true;
            rBDateEmploy.Text = "Дата приема";
            rBDateEmploy.UseVisualStyleBackColor = true;
            // 
            // rBPost
            // 
            rBPost.AutoSize = true;
            rBPost.Location = new Point(11, 104);
            rBPost.Name = "rBPost";
            rBPost.Size = new Size(107, 24);
            rBPost.TabIndex = 0;
            rBPost.TabStop = true;
            rBPost.Text = "Должность";
            rBPost.UseVisualStyleBackColor = true;
            // 
            // rBDep
            // 
            rBDep.AutoSize = true;
            rBDep.Location = new Point(11, 74);
            rBDep.Name = "rBDep";
            rBDep.Size = new Size(71, 24);
            rBDep.TabIndex = 0;
            rBDep.TabStop = true;
            rBDep.Text = "Отдел";
            rBDep.UseVisualStyleBackColor = true;
            // 
            // rBStatus
            // 
            rBStatus.AutoSize = true;
            rBStatus.Location = new Point(11, 44);
            rBStatus.Name = "rBStatus";
            rBStatus.Size = new Size(73, 24);
            rBStatus.TabIndex = 0;
            rBStatus.TabStop = true;
            rBStatus.Text = "Статус";
            rBStatus.UseVisualStyleBackColor = true;
            // 
            // rBFIO
            // 
            rBFIO.AutoSize = true;
            rBFIO.Location = new Point(11, 14);
            rBFIO.Name = "rBFIO";
            rBFIO.Size = new Size(63, 24);
            rBFIO.TabIndex = 0;
            rBFIO.TabStop = true;
            rBFIO.Text = "ФИО";
            rBFIO.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.Control;
            buttonSearch.Location = new Point(841, 21);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(110, 36);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 528);
            Controls.Add(panelSort);
            Controls.Add(panelFilter);
            Controls.Add(dataGridView);
            Controls.Add(buttonStatistics);
            Controls.Add(buttonSort);
            Controls.Add(buttonSearch);
            Controls.Add(buttonFilter);
            Controls.Add(buttonEmployeeInformation);
            Name = "Form1";
            Text = "Employee Information";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            panelSort.ResumeLayout(false);
            panelSort.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEmployeeInformation;
        private Button buttonStatistics;
        private DataGridView dataGridView;
        private Button buttonFilter;
        private TextBox textBoxLastName;
        private Button buttonSort;
        private Panel panelFilter;
        private ComboBox comboBoxPost;
        private ComboBox comboBoxDep;
        private ComboBox comboBoxStatus;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelSort;
        private RadioButton rBDateUneploy;
        private RadioButton rBDateEmploy;
        private RadioButton rBPost;
        private RadioButton rBDep;
        private RadioButton rBStatus;
        private RadioButton rBFIO;
        private Button buttonSearch;
    }
}
