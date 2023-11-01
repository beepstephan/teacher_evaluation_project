namespace teacher_evaluation_project.Forms {
    partial class FormFaq {
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
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(277, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(74, 18);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Питання";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormFaq
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 322);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormFaq";
            Text = "FAQ";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
    }
}