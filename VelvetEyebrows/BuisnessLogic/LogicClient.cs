using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelvetEyebrows
{
    class LogicClient
    {
        VelvetBrowsBDEntities db = new VelvetBrowsBDEntities();

        public List<PseudoClient> ListClients;

        public void LoadData()
        {
            var quert = from cli in db.Client
                        join gen in db.Gender on cli.GenderCode equals gen.Code
                        select new PseudoClient
                        {
                            ID = cli.ID,
                            FirstName = cli.FirstName,
                            LastName = cli.LastName,
                            Patronymic = cli.Patronymic,
                            Birthday = cli.Birthday,
                            RegistrationDate = cli.RegistrationDate,
                            Email = cli.Email,
                            Phone = cli.Phone,
                            GenderName=gen.Name,
                            PhotoPath = cli.PhotoPath
                        };
            this.ListClients = quert.ToList();
            SetPhotos();
        }
        public void SetPhotos()
        {
            foreach(var item in this.ListClients)
            {                
                    string path = Path.Combine(Application.StartupPath, item.PhotoPath);
                    using(FileStream stream =  new FileStream(path, FileMode.Open))
                    {
                    item.Photo = Image.FromStream(stream);
                    item.Photo = new Bitmap(item.Photo, new Size(30, 30));
                    stream.Dispose();
                    }                
            }
        }
    }
}
