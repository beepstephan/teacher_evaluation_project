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
            this.imgLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.imgTeacherlink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // imgLink
            // 
            this.imgLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imgLink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.imgLink.LinkColor = System.Drawing.Color.Gainsboro;
            this.imgLink.Location = new System.Drawing.Point(12, 238);
            this.imgLink.Name = "imgLink";
            this.imgLink.Size = new System.Drawing.Size(604, 39);
            this.imgLink.TabIndex = 0;
            this.imgLink.TabStop = true;
            this.imgLink.Text = "Зображення";
            this.imgLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 211);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgTeacherlink
            // 
            this.imgTeacherlink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgTeacherlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imgTeacherlink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.imgTeacherlink.LinkColor = System.Drawing.Color.Gainsboro;
            this.imgTeacherlink.Location = new System.Drawing.Point(12, 277);
            this.imgTeacherlink.Name = "imgTeacherlink";
            this.imgTeacherlink.Size = new System.Drawing.Size(604, 39);
            this.imgTeacherlink.TabIndex = 2;
            this.imgTeacherlink.TabStop = true;
            this.imgTeacherlink.Text = "Зображення викладачів";
            this.imgTeacherlink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imgTeacherlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.imgTeacherLink_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(628, 341);
            this.Controls.Add(this.imgTeacherlink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgLink);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormAbout";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private LinkLabel imgLink;
        private Label label1;
        private LinkLabel imgTeacherlink;
    }
}