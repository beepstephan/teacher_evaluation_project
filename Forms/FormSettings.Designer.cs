namespace teacher_evaluation_project.Forms {
    partial class FormSettings {
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
            lblFontSize = new Label();
            UpDownFontSize = new NumericUpDown();
            comboBoxFont = new ComboBox();
            lblFont = new Label();
            ((System.ComponentModel.ISupportInitialize)UpDownFontSize).BeginInit();
            SuspendLayout();
            // 
            // lblFontSize
            // 
            lblFontSize.AutoSize = true;
            lblFontSize.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFontSize.ForeColor = Color.Gainsboro;
            lblFontSize.Location = new Point(57, 36);
            lblFontSize.Name = "lblFontSize";
            lblFontSize.Size = new Size(108, 17);
            lblFontSize.TabIndex = 0;
            lblFontSize.Text = "Розмір шрифту";
            // 
            // UpDownFontSize
            // 
            UpDownFontSize.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            UpDownFontSize.Location = new Point(201, 34);
            UpDownFontSize.Maximum = new decimal(new int[] { 13, 0, 0, 0 });
            UpDownFontSize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            UpDownFontSize.Name = "UpDownFontSize";
            UpDownFontSize.Size = new Size(120, 23);
            UpDownFontSize.TabIndex = 4;
            UpDownFontSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            UpDownFontSize.ValueChanged += UpDownFontSize_ValueChanged;
            // 
            // comboBoxFont
            // 
            comboBoxFont.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFont.FormattingEnabled = true;
            comboBoxFont.ImeMode = ImeMode.NoControl;
            comboBoxFont.Items.AddRange(new object[] { "Microsoft Sans Serif", "Times New Roman", "Bahnschrift SemiBold" });
            comboBoxFont.Location = new Point(201, 79);
            comboBoxFont.Name = "comboBoxFont";
            comboBoxFont.RightToLeft = RightToLeft.No;
            comboBoxFont.Size = new Size(120, 24);
            comboBoxFont.TabIndex = 3;
            comboBoxFont.SelectedValueChanged += comboBoxFont_SelectedValueChanged;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFont.ForeColor = Color.Gainsboro;
            lblFont.Location = new Point(57, 82);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(53, 17);
            lblFont.TabIndex = 2;
            lblFont.Text = "Шрифт";
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 322);
            Controls.Add(UpDownFontSize);
            Controls.Add(comboBoxFont);
            Controls.Add(lblFont);
            Controls.Add(lblFontSize);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormSettings";
            Text = "Налаштування";
            ((System.ComponentModel.ISupportInitialize)UpDownFontSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFontSize;
        private NumericUpDown UpDownFontSize;
        private ComboBox comboBoxFont;
        private Label lblFont;
    }
}