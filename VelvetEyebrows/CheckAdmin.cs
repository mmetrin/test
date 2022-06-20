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
    public partial class CheckAdmin : Form
    {
        public CheckAdmin()
        {
            InitializeComponent();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            TxtCheckAdmin.Text.Trim();
            if (TxtCheckAdmin.Text == string.Empty)
            {
                MessageBox.Show("Введите код администратора и повторите попытку.", "Пустое поле ввода");
            }
            else if (TxtCheckAdmin.Text == "0000")
            {                
                new ServiceForm(true).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вы ввели неверный код, повторите попытку", "Ошибка ввода");
                TxtCheckAdmin.Text = "";
                TxtCheckAdmin.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Close();
        }
    }
}
