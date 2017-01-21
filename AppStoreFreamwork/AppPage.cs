using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreFreamwork
{
    class AppPage
    {
        public App App { get; set; }
        public PageSpec PageSpec { get; set; }
        public List<Comment> Comments { get; set; }

        public void download()
        {
            
        }
        public void addComment(Comment comment)
        {
            if (comment != null)
            {
                Comments.Add(comment);
            }
        }
    }
}
