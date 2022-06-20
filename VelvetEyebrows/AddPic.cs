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
    public partial class AddPic : Form
    {
        public AddPic()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            string FileName = "";
            using (OpenFileDialog file = new OpenFileDialog())
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(file.FileName, FileMode.Open))
                    {
                        FileName = file.SafeFileName;
                        PicPhoto.Image = Image.FromStream(stream);
                        string SavePath = Path.Combine(Application.StartupPath, "Test", FileName);
                        PicPhoto.Image.Save(SavePath);
                        stream.Close();
                        stream.Dispose();
                    }
                    file.Dispose();
                }
            }
           
        }
    }
}
