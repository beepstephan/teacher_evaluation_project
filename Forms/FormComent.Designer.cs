namespace teacher_evaluation_project.Forms {
    partial class FormComent {
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
            TextBoxComent = new RichTextBox();
            lblName = new Label();
            btnDone = new Button();
            trackBarRating = new TrackBar();
            lblCounter = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarRating).BeginInit();
            SuspendLayout();
            // 
            // TextBoxComent
            // 
            TextBoxComent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxComent.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxComent.Location = new Point(14, 113);
            TextBoxComent.MaxLength = 250;
            TextBoxComent.Name = "TextBoxComent";
            TextBoxComent.Size = new Size(600, 196);
            TextBoxComent.TabIndex = 0;
            TextBoxComent.Text = "";
            TextBoxComent.TextChanged += richTextBox1_TextChanged;
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
            btnDone.Click += button1_Click;
            // 
            // trackBarRating
            // 
            trackBarRating.Location = new Point(14, 41);
            trackBarRating.Minimum = 1;
            trackBarRating.Name = "trackBarRating";
            trackBarRating.Size = new Size(293, 45);
            trackBarRating.TabIndex = 3;
            trackBarRating.Value = 1;
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
            // FormComent
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 322);
            Controls.Add(lblCounter);
            Controls.Add(trackBarRating);
            Controls.Add(btnDone);
            Controls.Add(lblName);
            Controls.Add(TextBoxComent);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormComent";
            Text = "Дати відгук";
            ((System.ComponentModel.ISupportInitialize)trackBarRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox TextBoxComent;
        private Label lblName;
        private Button btnDone;
        private TrackBar trackBarRating;
        private Label lblCounter;
    }
}