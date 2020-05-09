using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedHelper
{
    public class Supply
    {
        public Supply(List<Portion> portions)
        {
            Portions = portions;
            DateTime = DateTime.Now;
        }

        public List<Portion> Portions { private set; get; }
        public DateTime DateTime { private set; get; }
    }
}

