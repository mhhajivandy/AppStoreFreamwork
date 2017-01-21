using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreFreamwork
{
    class Comment
    {
        public int ID { get; set; }
        public App App { get; set; }
        public User Author { get; set; }
        public String Description { get; set; }
        public  Rating Rating{ get; set; }
        public Comment ReplyTo { get; set; }
        public DateTime Date { get; set; }
        
    }
}
