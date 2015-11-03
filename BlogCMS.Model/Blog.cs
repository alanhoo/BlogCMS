using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCMS.Model
{
    public class Blog
    {
        public int BlogID { get; set; }
        public int WriterID { get; set; }
        public int ContentID { get; set; }
        public int StatusID { get; set; }
        public int CategoryID { get; set; }
        public int HistoryID { get; set; }
        public int CommentID { get; set; }
        public int TagDetailsID { get; set; }
        
        public DateTime DatePosted { get; set; }
        public DateTime DateExpired { get; set; }
        public string Title { get; set; }
    }
}
