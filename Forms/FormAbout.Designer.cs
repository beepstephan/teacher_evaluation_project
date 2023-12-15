namespace teacher_evaluation_project.Forms
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            imgLink = new LinkLabel();
            label1 = new Label();
            imgTeacherlink = new LinkLabel();
            SuspendLayout();
            // 
            // imgLink
            // 
            imgLink.Anchor = AnchorStyles.Bottom;
            imgLink.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            imgLink.ForeColor = SystemColors.ControlText;
            imgLink.LinkColor = Color.Gainsboro;
            imgLink.Location = new Point(12, 238);
            imgLink.Name = "imgLink";
            imgLink.Size = new Size(604, 39);
            imgLink.TabIndex = 0;
            imgLink.TabStop = true;
            imgLink.Text = "Зображення";
            imgLink.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(604, 211);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgTeacherlink
            // 
            imgTeacherlink.Anchor = AnchorStyles.Bottom;
            imgTeacherlink.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            imgTeacherlink.ForeColor = SystemColors.ControlText;
            imgTeacherlink.LinkColor = Color.Gainsboro;
            imgTeacherlink.Location = new Point(12, 277);
            imgTeacherlink.Name = "imgTeacherlink";
            imgTeacherlink.Size = new Size(604, 39);
            imgTeacherlink.TabIndex = 1;
            imgTeacherlink.TabStop = true;
            imgTeacherlink.Text = "Зображення викладачів";
            imgTeacherlink.TextAlign = ContentAlignment.MiddleCenter;
            imgTeacherlink.LinkClicked += imgTeacherLink_LinkClicked;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 341);
            Controls.Add(imgTeacherlink);
            Controls.Add(label1);
            Controls.Add(imgLink);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormAbout";
            Text = "About";
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel imgLink;
        private Label label1;
        private LinkLabel imgTeacherlink;
    }
}