namespace VelvetEyebrows
{
    partial class ServiceForm
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
            this.LabSearch = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LabFilter = new System.Windows.Forms.Label();
            this.LabSortCost = new System.Windows.Forms.Label();
            this.FilterDiscountCmb = new System.Windows.Forms.ComboBox();
            this.SortCostCmb = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnNearest = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TableService = new System.Windows.Forms.DataGridView();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.LogoText = new System.Windows.Forms.Label();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableService)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.LabSearch);
            this.MainPanel.Controls.Add(this.TxtSearch);
            this.MainPanel.Controls.Add(this.LabFilter);
            this.MainPanel.Controls.Add(this.LabSortCost);
            this.MainPanel.Controls.Add(this.FilterDiscountCmb);
            this.MainPanel.Controls.Add(this.SortCostCmb);
            this.MainPanel.Controls.Add(this.BtnBack);
            this.MainPanel.Controls.Add(this.AdminPanel);
            this.MainPanel.Controls.Add(this.TableService);
            this.MainPanel.Controls.Add(this.FooterPanel);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Tahoma", 12.01739F);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1518, 689);
            this.MainPanel.TabIndex = 1;
            // 
            // LabSearch
            // 
            this.LabSearch.AutoSize = true;
            this.LabSearch.Location = new System.Drawing.Point(284, 124);
            this.LabSearch.Name = "LabSearch";
            this.LabSearch.Size = new System.Drawing.Size(65, 24);
            this.LabSearch.TabIndex = 11;
            this.LabSearch.Text = "Поиск";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(365, 120);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(202, 31);
            this.TxtSearch.TabIndex = 10;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LabFilter
            // 
            this.LabFilter.AutoSize = true;
            this.LabFilter.Location = new System.Drawing.Point(1061, 122);
            this.LabFilter.Name = "LabFilter";
            this.LabFilter.Size = new System.Drawing.Size(217, 24);
            this.LabFilter.TabIndex = 9;
            this.LabFilter.Text = "Фильтрация по скидке";
            // 
            // LabSortCost
            // 
            this.LabSortCost.AutoSize = true;
            this.LabSortCost.Location = new System.Drawing.Point(587, 121);
            this.LabSortCost.Name = "LabSortCost";
            this.LabSortCost.Size = new System.Drawing.Size(244, 24);
            this.LabSortCost.TabIndex = 8;
            this.LabSortCost.Text = "Сортировка по стоимости";
            // 
            // FilterDiscountCmb
            // 
            this.FilterDiscountCmb.FormattingEnabled = true;
            this.FilterDiscountCmb.Items.AddRange(new object[] {
            "Все",
            "0-5%",
            "5-15%",
            "15-30%",
            "30-70%",
            "70-100%"});
            this.FilterDiscountCmb.Location = new System.Drawing.Point(1284, 119);
            this.FilterDiscountCmb.Name = "FilterDiscountCmb";
            this.FilterDiscountCmb.Size = new System.Drawing.Size(202, 31);
            this.FilterDiscountCmb.TabIndex = 7;
            this.FilterDiscountCmb.SelectedIndexChanged += new System.EventHandler(this.FilterDiscountCmb_SelectedIndexChanged);
            // 
            // SortCostCmb
            // 
            this.SortCostCmb.FormattingEnabled = true;
            this.SortCostCmb.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.SortCostCmb.Location = new System.Drawing.Point(837, 120);
            this.SortCostCmb.Name = "SortCostCmb";
            this.SortCostCmb.Size = new System.Drawing.Size(202, 31);
            this.SortCostCmb.TabIndex = 6;
            this.SortCostCmb.SelectedIndexChanged += new System.EventHandler(this.SortCostCmb_SelectedIndexChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(13, 112);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(95, 47);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // AdminPanel
            // 
            this.AdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminPanel.Controls.Add(this.BtnWrite);
            this.AdminPanel.Controls.Add(this.BtnDelete);
            this.AdminPanel.Controls.Add(this.BtnChange);
            this.AdminPanel.Controls.Add(this.BtnNearest);
            this.AdminPanel.Controls.Add(this.BtnAdd);
            this.AdminPanel.Location = new System.Drawing.Point(508, 572);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(978, 82);
            this.AdminPanel.TabIndex = 5;
            // 
            // BtnWrite
            // 
            this.BtnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnWrite.ForeColor = System.Drawing.Color.White;
            this.BtnWrite.Location = new System.Drawing.Point(274, 12);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(159, 50);
            this.BtnWrite.TabIndex = 7;
            this.BtnWrite.Text = "Записать";
            this.BtnWrite.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(805, 12);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(159, 50);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnChange.ForeColor = System.Drawing.Color.White;
            this.BtnChange.Location = new System.Drawing.Point(630, 12);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(159, 50);
            this.BtnChange.TabIndex = 3;
            this.BtnChange.Text = "Изменить";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnNearest
            // 
            this.BtnNearest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNearest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnNearest.ForeColor = System.Drawing.Color.White;
            this.BtnNearest.Location = new System.Drawing.Point(21, 12);
            this.BtnNearest.Name = "BtnNearest";
            this.BtnNearest.Size = new System.Drawing.Size(231, 50);
            this.BtnNearest.TabIndex = 6;
            this.BtnNearest.Text = "Ближайшие записи";
            this.BtnNearest.UseVisualStyleBackColor = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(453, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(159, 50);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TableService
            // 
            this.TableService.AllowUserToAddRows = false;
            this.TableService.AllowUserToDeleteRows = false;
            this.TableService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableService.BackgroundColor = System.Drawing.Color.White;
            this.TableService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableService.Location = new System.Drawing.Point(13, 178);
            this.TableService.Name = "TableService";
            this.TableService.ReadOnly = true;
            this.TableService.RowHeadersVisible = false;
            this.TableService.RowTemplate.Height = 24;
            this.TableService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableService.Size = new System.Drawing.Size(1473, 375);
            this.TableService.TabIndex = 4;
            this.TableService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableService_CellClick);
            this.TableService.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableService_CellDoubleClick);
            // 
            // FooterPanel
            // 
            this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.FooterPanel.Location = new System.Drawing.Point(3, 654);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1516, 35);
            this.FooterPanel.TabIndex = 1;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.HeaderPanel.Controls.Add(this.LogoText);
            this.HeaderPanel.Controls.Add(this.LogoPic);
            this.HeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1516, 93);
            this.HeaderPanel.TabIndex = 0;
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
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 689);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список услуг";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.AdminPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableService)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView TableService;
        private System.Windows.Forms.Label LabFilter;
        private System.Windows.Forms.Label LabSortCost;
        private System.Windows.Forms.ComboBox FilterDiscountCmb;
        private System.Windows.Forms.ComboBox SortCostCmb;
        private System.Windows.Forms.Button BtnWrite;
        private System.Windows.Forms.Button BtnNearest;
        private System.Windows.Forms.Label LabSearch;
        private System.Windows.Forms.TextBox TxtSearch;
    }
}