namespace VelvetEyebrows
{
    partial class CheckAdmin
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LogoText = new System.Windows.Forms.Label();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.TxtCheckAdmin = new System.Windows.Forms.TextBox();
            this.LabCheckAdmin = new System.Windows.Forms.Label();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.BtnBack);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Controls.Add(this.TxtCheckAdmin);
            this.MainPanel.Controls.Add(this.LabCheckAdmin);
            this.MainPanel.Controls.Add(this.BtnAdmin);
            this.MainPanel.Controls.Add(this.FooterPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Tahoma", 12.01739F);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(613, 392);
            this.MainPanel.TabIndex = 1;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(10, 99);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(95, 47);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.HeaderPanel.Controls.Add(this.BtnExit);
            this.HeaderPanel.Controls.Add(this.LogoText);
            this.HeaderPanel.Controls.Add(this.LogoPic);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(617, 93);
            this.HeaderPanel.TabIndex = 8;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(539, 13);
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
            // TxtCheckAdmin
            // 
            this.TxtCheckAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCheckAdmin.Location = new System.Drawing.Point(352, 154);
            this.TxtCheckAdmin.Name = "TxtCheckAdmin";
            this.TxtCheckAdmin.Size = new System.Drawing.Size(122, 31);
            this.TxtCheckAdmin.TabIndex = 7;
            // 
            // LabCheckAdmin
            // 
            this.LabCheckAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabCheckAdmin.AutoSize = true;
            this.LabCheckAdmin.Location = new System.Drawing.Point(139, 154);
            this.LabCheckAdmin.Name = "LabCheckAdmin";
            this.LabCheckAdmin.Size = new System.Drawing.Size(207, 24);
            this.LabCheckAdmin.TabIndex = 6;
            this.LabCheckAdmin.Text = "Код администратора:";
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin.Location = new System.Drawing.Point(143, 214);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(331, 62);
            this.BtnAdmin.TabIndex = 2;
            this.BtnAdmin.Text = "Войти в режим администратора";
            this.BtnAdmin.UseVisualStyleBackColor = false;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // FooterPanel
            // 
            this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.FooterPanel.Location = new System.Drawing.Point(0, 357);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(617, 35);
            this.FooterPanel.TabIndex = 1;
            // 
            // CheckAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 392);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CheckAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка на администратора";
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
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.TextBox TxtCheckAdmin;
        private System.Windows.Forms.Label LabCheckAdmin;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Button BtnBack;
    }
}