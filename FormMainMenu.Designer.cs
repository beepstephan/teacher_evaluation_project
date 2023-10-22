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
            btnSettings = new Button();
            btnTheme = new Button();
            btnSearch = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnTheme);
            panelMenu.Controls.Add(btnSearch);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.Image = Properties.Resources.settings_svgrepo_com_negate;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 260);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(12, 0, 0, 0);
            btnSettings.Size = new Size(220, 60);
            btnSettings.TabIndex = 4;
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
            btnTheme.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTheme.ForeColor = Color.Gainsboro;
            btnTheme.Image = Properties.Resources.color_palette_svgrepo_com_negate;
            btnTheme.ImageAlign = ContentAlignment.MiddleLeft;
            btnTheme.Location = new Point(0, 200);
            btnTheme.Name = "btnTheme";
            btnTheme.Padding = new Padding(12, 0, 0, 0);
            btnTheme.Size = new Size(220, 60);
            btnTheme.TabIndex = 3;
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
            btnSearch.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Gainsboro;
            btnSearch.Image = Properties.Resources.search_alt_2_svgrepo_com_negate;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(0, 140);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(12, 0, 0, 0);
            btnSearch.Size = new Size(220, 60);
            btnSearch.TabIndex = 2;
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
            btnHome.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.Gainsboro;
            btnHome.Image = Properties.Resources.home_svgrepo_com_negate;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 80);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(12, 0, 0, 0);
            btnHome.Size = new Size(220, 60);
            btnHome.TabIndex = 1;
            btnHome.Text = "   Головна";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Name = "FormMainMenu";
            Text = "FormMainMenu";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnHome;
        private Button btnSettings;
        private Button btnTheme;
        private Button btnSearch;
    }
}