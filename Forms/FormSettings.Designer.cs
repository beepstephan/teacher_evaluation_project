namespace teacher_evaluation_project.Forms
{
    partial class FormSettings
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
            lblFontSize = new Label();
            UpDownFontSize = new NumericUpDown();
            boxFontStyle = new ComboBox();
            lblFontStyle = new Label();
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
            UpDownFontSize.Size = new Size(48, 23);
            UpDownFontSize.TabIndex = 4;
            UpDownFontSize.TextAlign = HorizontalAlignment.Center;
            UpDownFontSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            UpDownFontSize.ValueChanged += UpDownFontSize_ValueChanged;
            // 
            // boxFontStyle
            // 
            boxFontStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            boxFontStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxFontStyle.FormattingEnabled = true;
            boxFontStyle.ImeMode = ImeMode.NoControl;
            boxFontStyle.Items.AddRange(new object[] { "Microsoft Sans Serif", "Times New Roman", "Bahnschrift SemiBold" });
            boxFontStyle.Location = new Point(201, 79);
            boxFontStyle.Name = "boxFontStyle";
            boxFontStyle.RightToLeft = RightToLeft.No;
            boxFontStyle.Size = new Size(150, 24);
            boxFontStyle.TabIndex = 3;
            boxFontStyle.SelectedValueChanged += comboBoxFont_SelectedValueChanged;
            // 
            // lblFontStyle
            // 
            lblFontStyle.AutoSize = true;
            lblFontStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFontStyle.ForeColor = Color.Gainsboro;
            lblFontStyle.Location = new Point(57, 82);
            lblFontStyle.Name = "lblFontStyle";
            lblFontStyle.Size = new Size(53, 17);
            lblFontStyle.TabIndex = 2;
            lblFontStyle.Text = "Шрифт";
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 341);
            Controls.Add(UpDownFontSize);
            Controls.Add(boxFontStyle);
            Controls.Add(lblFontStyle);
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
        private ComboBox boxFontStyle;
        private Label lblFontStyle;
    }
}