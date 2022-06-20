namespace VelvetEyebrows
{
    partial class TimeForm
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
            this.NameLab = new System.Windows.Forms.Label();
            this.TimeLab = new System.Windows.Forms.Label();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LogoText = new System.Windows.Forms.Label();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.PicPhotoUser = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhotoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.PicPhotoUser);
            this.MainPanel.Controls.Add(this.NameLab);
            this.MainPanel.Controls.Add(this.TimeLab);
            this.MainPanel.Controls.Add(this.FooterPanel);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Tahoma", 12.01739F);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(675, 513);
            this.MainPanel.TabIndex = 1;
            // 
            // NameLab
            // 
            this.NameLab.Location = new System.Drawing.Point(314, 167);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(314, 24);
            this.NameLab.TabIndex = 11;
            this.NameLab.Text = "Марина Викторовна";
            this.NameLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLab
            // 
            this.TimeLab.Location = new System.Drawing.Point(341, 129);
            this.TimeLab.Name = "TimeLab";
            this.TimeLab.Size = new System.Drawing.Size(256, 24);
            this.TimeLab.TabIndex = 10;
            this.TimeLab.Text = "Добрый день";
            this.TimeLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FooterPanel
            // 
            this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.FooterPanel.Location = new System.Drawing.Point(3, 478);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(673, 35);
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
            this.HeaderPanel.Size = new System.Drawing.Size(673, 93);
            this.HeaderPanel.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(595, 13);
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
            // PicPhotoUser
            // 
            this.PicPhotoUser.Location = new System.Drawing.Point(42, 144);
            this.PicPhotoUser.Name = "PicPhotoUser";
            this.PicPhotoUser.Size = new System.Drawing.Size(224, 234);
            this.PicPhotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPhotoUser.TabIndex = 12;
            this.PicPhotoUser.TabStop = false;
            // 
            // TimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 513);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeForm";
            this.Load += new System.EventHandler(this.TimeForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhotoUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox PicPhotoUser;
        private System.Windows.Forms.Label NameLab;
        private System.Windows.Forms.Label TimeLab;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.PictureBox LogoPic;
    }
}