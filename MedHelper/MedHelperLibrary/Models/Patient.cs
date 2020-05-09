using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedHelper
{
    public class Patient
    {
        public string Name { set; get; }
        public string Adress { set; get; }
        public string Birthdate { set; get; }
        public string Sex { set; get; }
        public string Description { get; set; }
        public string Treatment { set; get; }
        public string Procedures { set; get; }

    }
}
