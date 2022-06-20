namespace VelvetEyebrows
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PasswordLab = new System.Windows.Forms.Label();
            this.LoginLab = new System.Windows.Forms.Label();
            this.CapthaLab = new System.Windows.Forms.Label();
            this.CaptchaTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.BtnAuthorisation = new System.Windows.Forms.Button();
            this.BtnClients = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.BtnClient = new System.Windows.Forms.Button();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LogoText = new System.Windows.Forms.Label();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.PasswordLab);
            this.MainPanel.Controls.Add(this.LoginLab);
            this.MainPanel.Controls.Add(this.CapthaLab);
            this.MainPanel.Controls.Add(this.CaptchaTxt);
            this.MainPanel.Controls.Add(this.PasswordTxt);
            this.MainPanel.Controls.Add(this.LoginTxt);
            this.MainPanel.Controls.Add(this.BtnAuthorisation);
            this.MainPanel.Controls.Add(this.BtnClients);
            this.MainPanel.Controls.Add(this.BtnAdmin);
            this.MainPanel.Controls.Add(this.BtnClient);
            this.MainPanel.Controls.Add(this.FooterPanel);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Tahoma", 12.01739F);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1017, 508);
            this.MainPanel.TabIndex = 0;
            // 
            // PasswordLab
            // 
            this.PasswordLab.AutoSize = true;
            this.PasswordLab.Location = new System.Drawing.Point(583, 215);
            this.PasswordLab.Name = "PasswordLab";
            this.PasswordLab.Size = new System.Drawing.Size(85, 24);
            this.PasswordLab.TabIndex = 11;
            this.PasswordLab.Text = "Пароль:";
            // 
            // LoginLab
            // 
            this.LoginLab.AutoSize = true;
            this.LoginLab.Location = new System.Drawing.Point(583, 163);
            this.LoginLab.Name = "LoginLab";
            this.LoginLab.Size = new System.Drawing.Size(72, 24);
            this.LoginLab.TabIndex = 10;
            this.LoginLab.Text = "Логин:";
            // 
            // CapthaLab
            // 
            this.CapthaLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(133)))), ((int)(((byte)(154)))));
            this.CapthaLab.Font = new System.Drawing.Font("Syne Tactile", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapthaLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(163)))), ((int)(((byte)(180)))));
            this.CapthaLab.Location = new System.Drawing.Point(583, 274);
            this.CapthaLab.Name = "CapthaLab";
            this.CapthaLab.Size = new System.Drawing.Size(168, 52);
            this.CapthaLab.TabIndex = 9;
            this.CapthaLab.Text = "captcha";
            this.CapthaLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CaptchaTxt
            // 
            this.CaptchaTxt.Location = new System.Drawing.Point(778, 295);
            this.CaptchaTxt.Name = "CaptchaTxt";
            this.CaptchaTxt.Size = new System.Drawing.Size(123, 31);
            this.CaptchaTxt.TabIndex = 8;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(686, 208);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(215, 31);
            this.PasswordTxt.TabIndex = 7;
            // 
            // LoginTxt
            // 
            this.LoginTxt.Location = new System.Drawing.Point(686, 156);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(215, 31);
            this.LoginTxt.TabIndex = 6;
            // 
            // BtnAuthorisation
            // 
            this.BtnAuthorisation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAuthorisation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnAuthorisation.ForeColor = System.Drawing.Color.White;
            this.BtnAuthorisation.Location = new System.Drawing.Point(686, 354);
            this.BtnAuthorisation.Name = "BtnAuthorisation";
            this.BtnAuthorisation.Size = new System.Drawing.Size(158, 48);
            this.BtnAuthorisation.TabIndex = 5;
            this.BtnAuthorisation.Text = "Войти";
            this.BtnAuthorisation.UseVisualStyleBackColor = false;
            this.BtnAuthorisation.Click += new System.EventHandler(this.BtnAuthorisation_Click);
            // 
            // BtnClients
            // 
            this.BtnClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnClients.ForeColor = System.Drawing.Color.White;
            this.BtnClients.Location = new System.Drawing.Point(96, 340);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Size = new System.Drawing.Size(333, 62);
            this.BtnClients.TabIndex = 4;
            this.BtnClients.Text = "Клиенты";
            this.BtnClients.UseVisualStyleBackColor = false;
            this.BtnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin.Location = new System.Drawing.Point(96, 246);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(333, 62);
            this.BtnAdmin.TabIndex = 3;
            this.BtnAdmin.Text = "Режим администратора";
            this.BtnAdmin.UseVisualStyleBackColor = false;
            this.BtnAdmin.Click += new System.EventHandler(this.BrnAdmin_Click);
            // 
            // BtnClient
            // 
            this.BtnClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnClient.ForeColor = System.Drawing.Color.White;
            this.BtnClient.Location = new System.Drawing.Point(96, 156);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(333, 62);
            this.BtnClient.TabIndex = 2;
            this.BtnClient.Text = "Клиентский режим";
            this.BtnClient.UseVisualStyleBackColor = false;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // FooterPanel
            // 
            this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.FooterPanel.Location = new System.Drawing.Point(3, 473);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1015, 35);
            this.FooterPanel.TabIndex = 1;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.HeaderPanel.Controls.Add(this.BtnExit);
            this.HeaderPanel.Controls.Add(this.LogoText);
            this.HeaderPanel.Controls.Add(this.LogoPic);
            this.HeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1015, 93);
            this.HeaderPanel.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(937, 13);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(52, 47);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LogoText
            // 
            this.LogoText.AutoSize = true;
            this.LogoText.Font = new System.Drawing.Font("Tahoma", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoText.Location = new System.Drawing.Point(87, 13);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(143, 62);
            this.LogoText.TabIndex = 1;
            this.LogoText.Text = "Бархатные\r\nбровки";
            // 
            // LogoPic
            // 
            this.LogoPic.BackgroundImage = global::VelvetEyebrows.Properties.Resources.beauty;
            this.LogoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPic.Location = new System.Drawing.Point(10, 12);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(71, 67);
            this.LogoPic.TabIndex = 0;
            this.LogoPic.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 508);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Button BtnClients;
        private System.Windows.Forms.Label PasswordLab;
        private System.Windows.Forms.Label LoginLab;
        private System.Windows.Forms.Label CapthaLab;
        private System.Windows.Forms.TextBox CaptchaTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.Button BtnAuthorisation;
    }
}

