using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreFreamwork
{
    enum RATING_TYPE { App=0, Comment=1}
    class Rating
    {
        public int ID { get; set; }
        public int Point { get; set; }
        public int Type { get; set; }

        public void upRating() { Point++; }
        public void downRating() { Point--; }

        public void setRating(Rating rating)
        {
            if (rating.Type == (int)RATING_TYPE.App) {
                //do for app
            }
            else if (rating.Type == (int)RATING_TYPE.Comment)
            {
                //do for comment

            }
            else
            {
                //do nothing or error
            }
        }
    }
}
