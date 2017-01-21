using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreFreamwork
{
    class App
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public Developer Developer { get; set; }
        public Version Version { get; set; }
        public List<Permission> Permissions { get; set; }
        public Rating Rating { get; set; }
        public int DownloadCounter { get; set; }
        public float Price { get; set; }
        public void addPermission(Permission permission)
        {
            if (permission == null) return;
            if (Permissions.Contains(permission)) return;
            Permissions.Add(permission);

        }
        public void removePermission(Permission permission)
        {
            if (permission == null) return;
            if (Permissions.Contains(permission)) 
            Permissions.Remove(permission);
        }
        public void download() { DownloadCounter++; }
        
        public void purchase()
        {
            Developer.Income += this.Price;
        }




    }
}
