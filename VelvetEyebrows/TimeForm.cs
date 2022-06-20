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
    public partial class TimeForm : Form
    {
        Client user;
        public TimeForm(Client user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainForm().Show();
        }

        private void GetTime()
        {
            DateTime DateTimeNow = DateTime.Now;
            if ((DateTimeNow.Hour >= 9 && DateTimeNow.Hour < 11) || (DateTimeNow.Hour == 11 && DateTimeNow.Minute == 0))
            {
                TimeLab.Text = "Доброе утро!";
            }
            else if ((DateTimeNow.Hour >= 11 && DateTimeNow.Hour < 18) || (DateTimeNow.Hour == 18 && DateTimeNow.Minute == 0))
            {
                TimeLab.Text = "Добрый день!";
            }
            else if(DateTimeNow.Hour>18)
            {
                TimeLab.Text = "Добрый вечер!";
            }
        }

        private void TimeForm_Load(object sender, EventArgs e)
        {
            GetTime();
            NameLab.Text = user.FirstName + " " + user.Patronymic;
            GetPhoto(user);
        }

        private void GetPhoto(Client user)
        {
            string path = Path.Combine(Application.StartupPath, user.PhotoPath);
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                var ImagePic = Image.FromStream(stream);
                PicPhotoUser.Image = new Bitmap(ImagePic);
            };
        }
    }
}
