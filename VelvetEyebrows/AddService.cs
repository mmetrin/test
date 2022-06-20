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
    public partial class AddService : Form
    {
        string PathPhoto;
        VelvetBrowsBDEntities db = new VelvetBrowsBDEntities();
        public AddService()
        {
            InitializeComponent();
        }

       
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new ServiceForm(true).Show();
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog file = new OpenFileDialog())
            {
                if(file.ShowDialog() == DialogResult.OK)
                {
                    using(FileStream stream = new FileStream(file.FileName, FileMode.Open))
                    {
                        PicPhoto.Image = new Bitmap(Image.FromStream(stream));
                        PathPhoto = file.SafeFileName;
                    };
                }
            };
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CostTxt.Text) && (!string.IsNullOrEmpty(DiscountTxt.Text)) && (!string.IsNullOrEmpty(TitileTxt.Text)))
                {
                    if (double.TryParse(DiscountTxt.Text, out double Discount) && (decimal.TryParse(CostTxt.Text, out decimal Cost)))
                    {
                        Service service = new Service()
                        {
                            Discount = Discount,
                            Cost = Cost,
                            DurationInSeconds = Convert.ToInt32(DurationNum.Value),
                            Title = TitileTxt.Text,
                            Description = DescriptionTxt.Text,
                            MainImagePath= PathPhoto
                        };
                        db.Service.Add(service);
                        db.SaveChanges();
                        MessageBox.Show("Данные успешно добавлены");
                        this.Close();
                        new ServiceForm(true).Show();
                    }
                    else MessageBox.Show("Некорректные данные");
                }
                else MessageBox.Show("Заполните все обязательные поля");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

    }
}
