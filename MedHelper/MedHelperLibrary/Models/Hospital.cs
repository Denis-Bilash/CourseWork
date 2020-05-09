using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedHelper
{
    public class Hospital
    {
        public List<Medicine> Medicines { private set; get; }
        public List<User> Users { private set; get; }
        public List<Supply> Supplies { private set; get; }
        public List<Illness> Illnesses { private set; get; }

        public Hospital()
        {
            Medicines = new List<Medicine>();
            Users = new List<User>();
            Supplies = new List<Supply>();
            Illnesses = new List<Illness>();
        }
    }
}
