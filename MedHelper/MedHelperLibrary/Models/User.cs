using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedHelper
{
    public abstract class User
    {
        public string Login { set; get; }
        public string Password { set; get; }
        public string Access { get; set; }

    }
}
