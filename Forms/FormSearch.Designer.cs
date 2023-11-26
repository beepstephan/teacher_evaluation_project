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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Субботін",
            "Сергій",
            "Олександрович",
            "завідувач кафедризавідувач кафедризавідувач кафедризавідувач кафедри"}, -1);
            this.radBtnABC = new System.Windows.Forms.RadioButton();
            this.radBtnRating = new System.Windows.Forms.RadioButton();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.listTeachers = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // radBtnABC
            // 
            this.radBtnABC.AutoSize = true;
            this.radBtnABC.Checked = true;
            this.radBtnABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtnABC.ForeColor = System.Drawing.Color.Gainsboro;
            this.radBtnABC.Location = new System.Drawing.Point(39, 118);
            this.radBtnABC.Name = "radBtnABC";
            this.radBtnABC.Size = new System.Drawing.Size(116, 21);
            this.radBtnABC.TabIndex = 1;
            this.radBtnABC.TabStop = true;
            this.radBtnABC.Text = "За алфавітом";
            this.radBtnABC.UseVisualStyleBackColor = true;
            // 
            // radBtnRating
            // 
            this.radBtnRating.AutoSize = true;
            this.radBtnRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtnRating.ForeColor = System.Drawing.Color.Gainsboro;
            this.radBtnRating.Location = new System.Drawing.Point(183, 118);
            this.radBtnRating.Name = "radBtnRating";
            this.radBtnRating.Size = new System.Drawing.Size(116, 21);
            this.radBtnRating.TabIndex = 2;
            this.radBtnRating.Text = "За рейтингом";
            this.radBtnRating.UseVisualStyleBackColor = true;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSurname.Location = new System.Drawing.Point(39, 26);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(185, 23);
            this.textBoxSurname.TabIndex = 3;
            this.textBoxSurname.Text = "Введіть прізвище";
            // 
            // btnSearch
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
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(267, 26);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(138, 24);
            this.comboBoxDepartment.TabIndex = 5;
            this.comboBoxDepartment.Text = "Кафедра";
            // 
            // listTeachers
            // 
            this.listTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listTeachers.FullRowSelect = true;
            this.listTeachers.GridLines = true;
            this.listTeachers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listTeachers.Location = new System.Drawing.Point(39, 145);
            this.listTeachers.Name = "listTeachers";
            this.listTeachers.Size = new System.Drawing.Size(549, 164);
            this.listTeachers.TabIndex = 6;
            this.listTeachers.UseCompatibleStateImageBehavior = false;
            this.listTeachers.View = System.Windows.Forms.View.Details;
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
            this.columnHeader4.Width = 175;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Рейтинг";
            this.columnHeader5.Width = 70;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(628, 322);
            this.Controls.Add(this.listTeachers);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.radBtnRating);
            this.Controls.Add(this.radBtnABC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormSearch";
            this.Text = "Пошук викладачів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton radBtnABC;
        private RadioButton radBtnRating;
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