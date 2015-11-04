using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BlogCMS.Model;
using System.Data.SqlClient;
using Dapper; 


namespace BlogCMS.Data
{
    public class BlogRepo
    {
        private string connectionString;

        public BlogRepo()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BlogCMS"].ConnectionString;
        }

        public List<Blog> GetAllBlogPosts()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                var posts = cn.Query<Blog>("SELECT * FROM Blog").ToList();

                return posts;
            }
        }
    }
}
