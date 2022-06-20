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
    public partial class MainForm : Form
    {
        VelvetBrowsBDEntities db = new VelvetBrowsBDEntities();
        string Captcha;
        public MainForm()
        {
            InitializeComponent();
            GenCaptcha();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BrnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckAdmin checkAdmin = new CheckAdmin();
            checkAdmin.Show();
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            new ServiceForm(false).Show();
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            new ClientsForm().ShowDialog();
            this.Hide();
        }

        private void BtnAuthorisation_Click(object sender, EventArgs e)
        {
            string login = LoginTxt.Text;
            string pass = PasswordTxt.Text;
            //if (Captcha != CaptchaTxt.Text)
            //{
            //    MessageBox.Show("Повторите ввод!","Неверная капча");
            //    GenCaptcha();
            //    return;
            //}
            if (db.Client.Any(p => p.FirstName == pass && p.Email == login))
            {
                var user = db.Client.Where(p => p.FirstName == pass && p.Email == login).FirstOrDefault();
                new TimeForm(user).Show();
            }
            else
            {
                MessageBox.Show("Неверные данные!");
                GenCaptcha();
            }
        }

        private void GenCaptcha()
        {
            Random Random = new Random();
            Captcha = "";
            string Symbols = "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Z,X,C,V,B,N,M";
            Symbols += "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,z,x,c,v,b,n,m";
            Symbols += "1,2,3,4,5,6,7,8,9";
            string[] ListSymbols = Symbols.Split(',');
            for (int i = 0; i < 5; i++)
            {
                Captcha += ListSymbols[Random.Next(0, ListSymbols.Length - 1)];
            }

            CapthaLab.Text = Captcha;
        }
    }
}
