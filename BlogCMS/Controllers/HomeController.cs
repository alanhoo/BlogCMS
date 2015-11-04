using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogCMS.Data;


namespace BlogCMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var bRepo = new BlogRepo();
            var list = bRepo.GetAllBlogPosts();

            return View(list);
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}