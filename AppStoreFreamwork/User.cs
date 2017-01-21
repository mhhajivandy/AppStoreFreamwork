using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreFreamwork
{
    class User
    {
        public int ID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public float Credit { get; set; }
        public List<App> PurchasedList { get; set; }
        public List<App> DownloadedList { get; set; }
        public List<App> FavoriteList { get; set; }
        public Boolean purchase(App app)
        {

            if(app.Price>this.Credit)
                return false;
            Credit -= app.Price;
            app.purchase();
            PurchasedList.Add(app);
            return true;
        }
        public void download(App app)
        {
            if (app == null) return;
            if(app.Price==0 && purchase(app))
            {
                app.download();
                DownloadedList.Add(app);
            }
        }
        public void addToFavorite(App app)
        {
            if (app == null) return;
            if (!FavoriteList.Contains(app)) FavoriteList.Add(app);

        }
        public void removeFromFavorite(App app)
        {
            if (app == null) return;
            if (FavoriteList.Contains(app)) FavoriteList.Remove(app);
        }

    }
}
