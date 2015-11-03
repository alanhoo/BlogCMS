using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCMS.Model
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int ReplyToId { get; set; }

        public string UserName { get; set; }
        public DateTime DatePosted { get; set; }
        public string TheComment { get; set; }
    }
}
