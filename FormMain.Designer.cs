namespace teacher_evaluation_project
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelMenu = new Panel();
            btnTheme = new Button();
            btnAbout = new Button();
            btnFaq = new Button();
            btnDev = new Button();
            btnLogIn = new Button();
            btnSettings = new Button();
            btnSearch = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            picLogo = new PictureBox();
            lblLogo = new Label();
            panelTitleBar = new Panel();
            titleBarText = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 30, 65);
            panelMenu.Controls.Add(btnTheme);
            panelMenu.Controls.Add(btnAbout);
            panelMenu.Controls.Add(btnFaq);
            panelMenu.Controls.Add(btnDev);
            panelMenu.Controls.Add(btnLogIn);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnSearch);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(240, 436);
            panelMenu.TabIndex = 0;
            // 
            // btnTheme
            // 
            btnTheme.Dock = DockStyle.Top;
            btnTheme.FlatAppearance.BorderSize = 0;
            btnTheme.FlatStyle = FlatStyle.Flat;
            btnTheme.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnTheme.ForeColor = Color.Gainsboro;
            btnTheme.Image = Properties.Resources.color_palette_svgrepo_com_negate;
            btnTheme.ImageAlign = ContentAlignment.MiddleLeft;
            btnTheme.Location = new Point(0, 236);
            btnTheme.Name = "btnTheme";
            btnTheme.Padding = new Padding(5, 0, 0, 0);
            btnTheme.Size = new Size(240, 60);
            btnTheme.TabIndex = 11;
            btnTheme.Text = "   Тема";
            btnTheme.TextAlign = ContentAlignment.MiddleLeft;
            btnTheme.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTheme.UseVisualStyleBackColor = true;
            btnTheme.Click += btnTheme_Click;
            // 
            // btnAbout
            // 
            btnAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbout.ForeColor = Color.Gainsboro;
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(160, 375);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(80, 60);
            btnAbout.TabIndex = 8;
            btnAbout.Text = "About";
            btnAbout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += brnAbout_Click;
            // 
            // btnFaq
            // 
            btnFaq.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFaq.FlatAppearance.BorderSize = 0;
            btnFaq.FlatStyle = FlatStyle.Flat;
            btnFaq.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFaq.ForeColor = Color.Gainsboro;
            btnFaq.ImageAlign = ContentAlignment.MiddleLeft;
            btnFaq.Location = new Point(0, 375);
            btnFaq.Name = "btnFaq";
            btnFaq.Size = new Size(80, 60);
            btnFaq.TabIndex = 6;
            btnFaq.Text = "FAQ";
            btnFaq.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFaq.UseVisualStyleBackColor = true;
            btnFaq.Click += btnFaq_Click;
            // 
            // btnDev
            // 
            btnDev.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDev.FlatAppearance.BorderSize = 0;
            btnDev.FlatStyle = FlatStyle.Flat;
            btnDev.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDev.ForeColor = Color.Gainsboro;
            btnDev.ImageAlign = ContentAlignment.MiddleLeft;
            btnDev.Location = new Point(80, 375);
            btnDev.Name = "btnDev";
            btnDev.Size = new Size(80, 60);
            btnDev.TabIndex = 7;
            btnDev.Text = "Розробники";
            btnDev.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDev.UseVisualStyleBackColor = true;
            btnDev.Click += btnDev_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogIn.BackColor = Color.ForestGreen;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.ForeColor = Color.Gainsboro;
            btnLogIn.Image = Properties.Resources.login_svgrepo_com_negate;
            btnLogIn.Location = new Point(0, 315);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Padding = new Padding(5, 0, 0, 0);
            btnLogIn.Size = new Size(240, 60);
            btnLogIn.TabIndex = 14;
            btnLogIn.Text = "   Увійти";
            btnLogIn.TextAlign = ContentAlignment.MiddleLeft;
            btnLogIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogin_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.Image = Properties.Resources.settings_svgrepo_com_negate;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 176);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(5, 0, 0, 0);
            btnSettings.Size = new Size(240, 60);
            btnSettings.TabIndex = 12;
            btnSettings.Text = "   Налаштування";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Top;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Gainsboro;
            btnSearch.Image = Properties.Resources.search_alt_2_svgrepo_com_negate;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(0, 116);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(5, 0, 0, 0);
            btnSearch.Size = new Size(240, 60);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "   Пошук викладачів";
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.Gainsboro;
            btnHome.Image = Properties.Resources.home_svgrepo_com_negate;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 56);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(5, 0, 0, 0);
            btnHome.Size = new Size(240, 60);
            btnHome.TabIndex = 9;
            btnHome.Text = "   Головна";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(picLogo);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(240, 56);
            panelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.imgLogo;
            picLogo.Location = new Point(12, 7);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(43, 43);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Right;
            lblLogo.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogo.ForeColor = Color.Gainsboro;
            lblLogo.Location = new Point(52, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(188, 56);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Feedback";
            lblLogo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(27, 27, 63);
            panelTitleBar.Controls.Add(titleBarText);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(240, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(644, 56);
            panelTitleBar.TabIndex = 1;
            // 
            // titleBarText
            // 
            titleBarText.BackColor = Color.Transparent;
            titleBarText.Dock = DockStyle.Fill;
            titleBarText.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            titleBarText.ForeColor = Color.Gainsboro;
            titleBarText.Location = new Point(0, 0);
            titleBarText.Name = "titleBarText";
            titleBarText.Size = new Size(644, 56);
            titleBarText.TabIndex = 0;
            titleBarText.Text = "Form.Text";
            titleBarText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(35, 35, 80);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(240, 56);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(644, 380);
            panelDesktop.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 436);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MinimumSize = new Size(900, 475);
            Name = "FormMain";
            Text = "Оцінювання викладачів";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelLogo;
        private Button btnSettings;
        private Button btnTheme;
        private Button btnSearch;
        private Button btnAbout;
        private Button btnFaq;
        private Button btnDev;
        private Panel panelTitleBar;
        private Label titleBarText;
        private Panel panelDesktop;
        private PictureBox picLogo;
        private Label lblLogo;
        public Button btnLogIn;
        private Panel panelMenu;
        internal Button btnHome;
    }
}