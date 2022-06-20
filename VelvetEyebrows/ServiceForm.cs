using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelvetEyebrows
{
    public partial class ServiceForm : Form
    {
        VelvetBrowsBDEntities db = new VelvetBrowsBDEntities();
        LogicService LogicService;
        public ServiceForm(bool AdminCheck)
        {
            InitializeComponent();
            AdminPanel.Visible = AdminCheck;
            this.LogicService = new LogicService();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void TableService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int id = Convert.ToInt32(TableService.Rows[0].Cells["ID".Value]);            
            //new AddPic().ShowDialog();
        }
        
        void RenameColumns()
        {
            TableService.Columns["ID"].Visible = false;
            TableService.Columns["Title"].HeaderText = "Название";
            TableService.Columns["Description"].HeaderText = "Описание";
            TableService.Columns["DurationInSeconds"].HeaderText = "Длительность, с";
            TableService.Columns["Discount"].HeaderText = "Скидка";
            TableService.Columns["Cost"].HeaderText = "Цена, руб.";
            TableService.Columns["MainImagePath"].HeaderText = "Изображение";
            TableService.Columns["ServicePhoto"].Visible = false;
            TableService.Columns["ClientService"].Visible = false;
        }

        public void UpdateTable()
        {
            try
            {
                this.LogicService.LoadServices();
                this.LogicService.SortService(SortCostCmb.SelectedIndex);
                this.LogicService.FilterServices(FilterDiscountCmb.SelectedIndex);
                this.LogicService.SearchServices(TxtSearch.Text);
                //поле содержит все данные листа
                TableService.DataSource = this.LogicService.ServiceList;
                RenameColumns();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void SortCostCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LogicService.SortService(SortCostCmb.SelectedIndex);
            TableService.DataSource = this.LogicService.ServiceList;
        }

        private void FilterDiscountCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void TableService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(this.TableService.SelectedRows[0].Cells["ID"].Value);
            new ChangeService(Id).ShowDialog();
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            new AddService().Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(TableService.SelectedRows[0].Cells["ID"].Value);
            Service service = new Service();
            service = db.Service.Where(p => p.ID == Id).FirstOrDefault();
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?","Подтвреждение удаления", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                db.Service.Remove(service);
                db.SaveChanges();
                MessageBox.Show("Данные успешно удалены");
            }
           
        }
    }
}
