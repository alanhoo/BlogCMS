using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCMS.Model
{
    public class History
    {
        public int HistoryID { get; set; }
        public int UserID { get; set; }
        public int ActionID { get; set; }

        public DateTime Date { get; set; }
        public string Note { get; set; }
    }
}
