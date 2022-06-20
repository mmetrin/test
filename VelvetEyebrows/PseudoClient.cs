using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelvetEyebrows
{
    class PseudoClient : Client
    {
        public string GenderName { get; set; }

        public Image Photo { get; set; }
    }
}
