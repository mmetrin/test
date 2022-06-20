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
    public partial class ChangeService : Form
    {
        VelvetBrowsBDEntities db = new VelvetBrowsBDEntities();
        int IdService;
        Service service = new Service();
        string PhotoPath;
        public ChangeService(int Id)
        {
            InitializeComponent();
            IdService = Id;
            service = db.Service.Where(p => p.ID == IdService).FirstOrDefault();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new ServiceForm(true).Show();
        }

        private void ChangeService_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        void UpdateData()
        {
            CostTxt.Text = service.Cost.ToString();
            DescriptionTxt.Text = service.Description.ToString();
            DiscountTxt.Text = service.Discount.ToString();
            TitileTxt.Text = service.Title.ToString();
            DurationNum.Value = service.DurationInSeconds;
            GetPhoto();
        }

        void GetPhoto()
        {
            using(FileStream stream = new FileStream(service.MainImagePath, FileMode.Open))
            {
                PicPhoto.Image = new Bitmap(Image.FromStream(stream));
            };
        }

        private void ChangePhoto_Click(object sender, EventArgs e)
        {
           using(OpenFileDialog file = new OpenFileDialog())
            {
                if(file.ShowDialog() == DialogResult.OK)
                {
                    using(FileStream stream = new FileStream(file.FileName, FileMode.Open))
                    {
                        PicPhoto.Image = new Bitmap(Image.FromStream(stream));
                        PhotoPath = file.SafeFileName;
                    };
                }
            };
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CostTxt.Text) && (!string.IsNullOrEmpty(TitileTxt.Text)) && (!string.IsNullOrEmpty(DiscountTxt.Text)))
                {
                    if (double.TryParse(DiscountTxt.Text, out double Discount) && (decimal.TryParse(CostTxt.Text, out decimal Cost)))
                    {
                        Service service = new Service()
                        {
                            DurationInSeconds = Convert.ToInt32(DurationNum.Value),
                            Discount=Discount,
                            Cost = Cost,
                            Description = DescriptionTxt.Text,
                            Title=TitileTxt.Text,
                            MainImagePath = PhotoPath
                        };
                        db.Service.Add(service);
                        db.SaveChanges();
                    }
                    else MessageBox.Show("Некорректные данные");
                  
                }
                else MessageBox.Show("Заполните обязательные поля");
              
            }
            catch { MessageBox.Show("Ошибочка"); }
          
        }

      
    }
}
