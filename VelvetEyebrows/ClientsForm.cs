using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelvetEyebrows
{
    public partial class ClientsForm : Form
    {
        LogicClient LogicClient;
        public ClientsForm()
        {
            InitializeComponent();
            this.LogicClient = new LogicClient();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Close();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            LogicClient.LoadData();
            TableClients.DataSource = LogicClient.ListClients;
            RenameColumns();
        }

        void RenameColumns()
        {
            TableClients.Columns["FirstName"].HeaderText = "Имя";
            TableClients.Columns["LastName"].HeaderText = "Фамилия";
            TableClients.Columns["Patronymic"].HeaderText = "Отчество";
            TableClients.Columns["Birthday"].HeaderText = "Дата рождения";
            TableClients.Columns["RegistrationDate"].HeaderText = "Дата регистрации";
            TableClients.Columns["Email"].HeaderText = "Почта";
            TableClients.Columns["Photo"].HeaderText = "Фото";
            TableClients.Columns["Phone"].HeaderText = "Телефон";
            TableClients.Columns["GenderName"].HeaderText = "Пол";
            TableClients.Columns["PhotoPath"].Visible = false;
            TableClients.Columns["ID"].Visible = false;
            TableClients.Columns["GenderCode"].Visible = false;
            TableClients.Columns["Gender"].Visible = false;
            TableClients.Columns["ClientService"].Visible = false;
            TableClients.Columns["Tag"].Visible = false;
        }

        private void TableClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
