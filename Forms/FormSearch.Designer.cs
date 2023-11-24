namespace teacher_evaluation_project.Forms {
    partial class FormSearch {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Степаненко", "Степан", "Степанович" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Іванов", "Іван", "Іванович" }, -1);
            radioButtonABC = new RadioButton();
            radioButtonRating = new RadioButton();
            textBoxSurname = new TextBox();
            btnSearch = new Button();
            comboBoxDepartment = new ComboBox();
            listViewTeachers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // radioButtonABC
            // 
            radioButtonABC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonABC.AutoSize = true;
            radioButtonABC.Checked = true;
            radioButtonABC.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonABC.ForeColor = Color.Gainsboro;
            radioButtonABC.Location = new Point(320, 131);
            radioButtonABC.Name = "radioButtonABC";
            radioButtonABC.Size = new Size(116, 21);
            radioButtonABC.TabIndex = 1;
            radioButtonABC.TabStop = true;
            radioButtonABC.Text = "За алфавітом";
            radioButtonABC.UseVisualStyleBackColor = true;
            // 
            // radioButtonRating
            // 
            radioButtonRating.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonRating.AutoSize = true;
            radioButtonRating.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonRating.ForeColor = Color.Gainsboro;
            radioButtonRating.Location = new Point(472, 132);
            radioButtonRating.Name = "radioButtonRating";
            radioButtonRating.Size = new Size(116, 21);
            radioButtonRating.TabIndex = 2;
            radioButtonRating.Text = "За рейтингом";
            radioButtonRating.UseVisualStyleBackColor = true;
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
            // listViewTeachers
            // 
            listViewTeachers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewTeachers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewTeachers.FullRowSelect = true;
            listViewTeachers.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewTeachers.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listViewTeachers.Location = new Point(39, 159);
            listViewTeachers.Name = "listViewTeachers";
            listViewTeachers.Size = new Size(549, 150);
            listViewTeachers.TabIndex = 6;
            listViewTeachers.UseCompatibleStateImageBehavior = false;
            listViewTeachers.View = View.Details;
            listViewTeachers.SelectedIndexChanged += listViewTeachers_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Прізвище";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ім'я";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Побатькові";
            columnHeader3.Width = 80;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 322);
            Controls.Add(listViewTeachers);
            Controls.Add(comboBoxDepartment);
            Controls.Add(btnSearch);
            Controls.Add(textBoxSurname);
            Controls.Add(radioButtonRating);
            Controls.Add(radioButtonABC);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormSearch";
            Text = "Пошук викладачів";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButtonABC;
        private RadioButton radioButtonRating;
        private TextBox textBoxSurname;
        private Button btnSearch;
        private ComboBox comboBoxDepartment;
        private ListView listViewTeachers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}