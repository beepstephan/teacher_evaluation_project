namespace teacher_evaluation_project {
    partial class FormMainMenu {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panelMenu = new Panel();
            brnAbout = new Button();
            btnFaq = new Button();
            btnDev = new Button();
            btnLogin = new Button();
            btnSettings = new Button();
            btnTheme = new Button();
            btnSearch = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            logo = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnTheme);
            panelMenu.Controls.Add(brnAbout);
            panelMenu.Controls.Add(btnFaq);
            panelMenu.Controls.Add(btnDev);
            panelMenu.Controls.Add(btnLogin);
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
            // brnAbout
            // 
            brnAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            brnAbout.FlatAppearance.BorderSize = 0;
            brnAbout.FlatStyle = FlatStyle.Flat;
            brnAbout.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            brnAbout.ForeColor = Color.Gainsboro;
            brnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            brnAbout.Location = new Point(160, 375);
            brnAbout.Name = "brnAbout";
            brnAbout.Size = new Size(80, 60);
            brnAbout.TabIndex = 8;
            brnAbout.Text = "About";
            brnAbout.TextImageRelation = TextImageRelation.ImageBeforeText;
            brnAbout.UseVisualStyleBackColor = true;
            brnAbout.Click += brnAbout_Click;
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
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogin.BackColor = Color.Green;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Gainsboro;
            btnLogin.Image = Properties.Resources.login_svgrepo_com_negate;
            btnLogin.Location = new Point(0, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(12, 0, 0, 0);
            btnLogin.Size = new Size(240, 60);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "   Увійти";
            btnLogin.TextAlign = ContentAlignment.MiddleLeft;
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
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
            btnSettings.Location = new Point(0, 195);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(12, 0, 0, 0);
            btnSettings.Size = new Size(240, 60);
            btnSettings.TabIndex = 12;
            btnSettings.Text = "   Налаштування";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
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
            btnTheme.Location = new Point(0, 255);
            btnTheme.Name = "btnTheme";
            btnTheme.Padding = new Padding(12, 0, 0, 0);
            btnTheme.Size = new Size(240, 60);
            btnTheme.TabIndex = 11;
            btnTheme.Text = "   Тема";
            btnTheme.TextAlign = ContentAlignment.MiddleLeft;
            btnTheme.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTheme.UseVisualStyleBackColor = true;
            btnTheme.Click += btnTheme_Click;
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
            btnSearch.Location = new Point(0, 135);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(12, 0, 0, 0);
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
            btnHome.Location = new Point(0, 75);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(12, 0, 0, 0);
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
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(logo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(240, 75);
            panelLogo.TabIndex = 0;
            // 
            // logo
            // 
            logo.Dock = DockStyle.Fill;
            logo.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            logo.ForeColor = Color.Gainsboro;
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(240, 75);
            logo.TabIndex = 1;
            logo.Text = "logo";
            logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(240, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(644, 75);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(644, 75);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Form.Text";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(240, 75);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(644, 361);
            panelDesktop.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(884, 436);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(900, 475);
            Name = "FormMainMenu";
            Text = "Оцінка викладачів";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnSettings;
        private Button btnTheme;
        private Button btnSearch;
        private Button btnHome;
        private Button btnLogin;
        private Button brnAbout;
        private Button btnFaq;
        private Button btnDev;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label logo;
        private Panel panelDesktop;
    }
}