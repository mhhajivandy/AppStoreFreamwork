using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreFreamwork
{
    class Developer:User
    {
        public List<App> DevApps { get; set; }
        public float Income { get; set; }

        public void addNewApp(App app)
        {
            if (app == null) return;
            if (DevApps.Contains(app)) return;
            DevApps.Add(app);
        }
    }
}
