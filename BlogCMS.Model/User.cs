using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCMS.Model
{
    public class User
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
