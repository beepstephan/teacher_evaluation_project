namespace teacher_evaluation_project.Forms
{
    partial class FormFaq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaq));
            lblTitle = new Label();
            labelGuide = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(11, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(604, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Покроковий гайд для користувача";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGuide
            // 
            labelGuide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelGuide.ForeColor = Color.Gainsboro;
            labelGuide.Location = new Point(11, 57);
            labelGuide.Name = "labelGuide";
            labelGuide.Size = new Size(605, 275);
            labelGuide.TabIndex = 1;
            labelGuide.Text = resources.GetString("labelGuide.Text");
            labelGuide.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormFaq
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 341);
            Controls.Add(labelGuide);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormFaq";
            Text = "FAQ";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label labelGuide;
    }
}