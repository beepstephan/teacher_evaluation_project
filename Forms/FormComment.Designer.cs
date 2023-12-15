namespace teacher_evaluation_project.Forms
{
    partial class FormComment
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
            textBoxComment = new RichTextBox();
            lblName = new Label();
            btnDone = new Button();
            trackBarRate = new TrackBar();
            lblCounter = new Label();
            lblRate = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarRate).BeginInit();
            SuspendLayout();
            // 
            // textBoxComment
            // 
            textBoxComment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxComment.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxComment.Location = new Point(14, 113);
            textBoxComment.MaxLength = 250;
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(600, 215);
            textBoxComment.TabIndex = 1;
            textBoxComment.Text = "";
            textBoxComment.TextChanged += textBoxComment_TextChanged;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Gainsboro;
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(628, 28);
            lblName.TabIndex = 1;
            lblName.Text = "ПІБ";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDone.BackColor = Color.FromArgb(30, 30, 65);
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDone.ForeColor = Color.Gainsboro;
            btnDone.Location = new Point(433, 61);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(144, 34);
            btnDone.TabIndex = 2;
            btnDone.Text = "Готово";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // trackBarRate
            // 
            trackBarRate.Location = new Point(14, 41);
            trackBarRate.Minimum = 1;
            trackBarRate.Name = "trackBarRate";
            trackBarRate.Size = new Size(293, 45);
            trackBarRate.TabIndex = 0;
            trackBarRate.Value = 1;
            trackBarRate.ValueChanged += trackBarRating_ValueChanged;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCounter.ForeColor = Color.Gainsboro;
            lblCounter.Location = new Point(14, 92);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(111, 17);
            lblCounter.TabIndex = 4;
            lblCounter.Text = "Символів: 0/250";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.ForeColor = Color.Gainsboro;
            lblRate.Location = new Point(271, 78);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(36, 17);
            lblRate.TabIndex = 5;
            lblRate.Text = "1/10";
            // 
            // FormComment
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 341);
            Controls.Add(lblRate);
            Controls.Add(lblCounter);
            Controls.Add(trackBarRate);
            Controls.Add(btnDone);
            Controls.Add(lblName);
            Controls.Add(textBoxComment);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormComment";
            Text = "Дати відгук";
            ((System.ComponentModel.ISupportInitialize)trackBarRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox textBoxComment;
        private Label lblName;
        private Button btnDone;
        private TrackBar trackBarRate;
        private Label lblCounter;
        private Label lblRate;
    }
}