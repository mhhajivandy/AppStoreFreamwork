using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreFreamwork
{
    class PageSpec
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public String Category { get; set; }
        public String Downloaded { get; set; }
        public String Version { get; set; }
        public List<String> Images { get; set; }
        public List<String> Videos { get; set; }
        public List<String> LastChanges { get; set; }
        public List<String> Permissions { get; set; }    
    }
}
