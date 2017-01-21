using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreFreamwork
{
    class Version
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Release { get; set; }
        public String show()
        {
            return Major.ToString() + "." + Minor.ToString() + "." + Release.ToString();
        }
    }
}
