namespace teacher_evaluation_project.Forms
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxPosition = new ComboBox();
            this.listTeachers = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.sortComboBox = new ComboBox();
            this.SuspendLayout();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            this.textBoxSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSurname.Location = new System.Drawing.Point(39, 26);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(185, 23);
            this.textBoxSurname.TabIndex = 3;
            this.textBoxSurname.Text = "Введіть прізвище";
            textBoxSurname.TabIndex = 3;
            textBoxSurname.Text = "Введіть прізвище";
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Location = new System.Drawing.Point(267, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 33);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += btnSearch_Click;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            comboBoxPosition.Anchor = AnchorStyles.Top;
            comboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPosition.DropDownWidth = 226;
            comboBoxPosition.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Items.AddRange(new object[] { "Усі посади", "Завідувач кафедри", "Професор", "Доцент", "Старший викладач", "Завідувач лабораторії", "Асистент / Інженер / Лаборант", "Сумісник / Погодинник" });
            comboBoxPosition.Location = new Point(292, 25);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(152, 24);
            comboBoxPosition.TabIndex = 5;
            comboBoxDepartment.TabIndex = 5;
            comboBoxDepartment.Text = "Кафедра";
            // 
            this.listTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listTeachers.FullRowSelect = true;
            this.listTeachers.GridLines = true;
            this.listTeachers.Location = new System.Drawing.Point(39, 145);
            this.listTeachers.MultiSelect = false;
            this.listTeachers.Name = "listTeachers";
            this.listTeachers.Size = new System.Drawing.Size(549, 183);
            this.listTeachers.TabIndex = 6;
            this.listTeachers.UseCompatibleStateImageBehavior = false;
            this.listTeachers.View = System.Windows.Forms.View.Details;

            listTeachers.View = View.Details;
            listTeachers.SelectedIndexChanged += listTeachers_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Прізвище";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ім\'я";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Побатькові";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Посада";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Рейтинг";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 40;
            // 
            // sortComboBox
            // 
            sortComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Items.AddRange(new object[] { "Рейтинг за зростанням", "Рейтинг за спаданням", "За алфавітом А-Я", "За алфавітом Я-А" });
            sortComboBox.Location = new Point(403, 115);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(185, 24);
            sortComboBox.TabIndex = 7;
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 322);
            Controls.Add(sortComboBox);
            Controls.Add(listTeachers);
            Controls.Add(comboBoxPosition);
            Controls.Add(btnSearch);
            Controls.Add(textBoxSurname);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormSearch";
            Text = "Пошук викладачів";
            ResumeLayout(false);
            PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxSurname;
        private Button btnSearch;
        private ComboBox comboBoxPosition;
        private ListView listTeachers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ComboBox sortComboBox;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}