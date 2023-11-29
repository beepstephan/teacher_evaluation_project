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
            textBoxSurname = new TextBox();
            btnSearch = new Button();
            comboBoxDepartment = new ComboBox();
            listTeachers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.Top;
            textBoxSurname.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSurname.Location = new Point(39, 26);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(185, 23);
            textBoxSurname.TabIndex = 3;
            textBoxSurname.Text = "Введіть прізвище";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.FromArgb(30, 30, 65);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Gainsboro;
            btnSearch.Location = new Point(267, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 33);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Anchor = AnchorStyles.Top;
            comboBoxDepartment.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(267, 26);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(138, 24);
            comboBoxDepartment.TabIndex = 5;
            comboBoxDepartment.Text = "Кафедра";
            // 
            // listTeachers
            // 
            listTeachers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listTeachers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listTeachers.FullRowSelect = true;
            listTeachers.GridLines = true;
            listTeachers.Location = new Point(39, 145);
            listTeachers.MultiSelect = false;
            listTeachers.Name = "listTeachers";
            listTeachers.Size = new Size(549, 183);
            listTeachers.TabIndex = 6;
            listTeachers.UseCompatibleStateImageBehavior = false;
            listTeachers.View = View.Details;
            listTeachers.SelectedIndexChanged += listTeachers_SelectedIndexChanged;
            listTeachers.SizeChanged += listTeachers_SizeChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Прізвище";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ім'я";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Побатькові";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Посада";
            columnHeader4.Width = 175;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Рейтинг";
            columnHeader5.Width = 70;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 341);
            Controls.Add(listTeachers);
            Controls.Add(comboBoxDepartment);
            Controls.Add(btnSearch);
            Controls.Add(textBoxSurname);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormSearch";
            Text = "Пошук викладачів";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxSurname;
        private Button btnSearch;
        private ComboBox comboBoxDepartment;
        private ListView listTeachers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}