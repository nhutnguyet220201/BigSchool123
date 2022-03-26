using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BigSchool_NhutNguyet.Models;
using BigSchool_NhutNguyet.ViewModel;
using Microsoft.AspNet.Identity.EntityFramework;


namespace BigSchool_NhutNguyet.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbcontext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbcontext();
        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);

            return View(upcommingCourses);
        }

            public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}