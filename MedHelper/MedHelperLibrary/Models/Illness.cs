using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedHelper
{
    public class Illness
    {
        public List<string> Symptoms { private set; get; }
        public string Description { private set; get; }
        public string TreatMethods { private set; get; }
        public string Spreading { private set; get; }
    }
}
