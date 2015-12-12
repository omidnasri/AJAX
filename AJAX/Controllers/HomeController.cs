using System;
using System.Web.Mvc;

namespace AJAX.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetDateTime()
        {
            return DateTime.Now.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetName(string yourname)
        {
            return yourname;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string GetYear()
        {
            return DateTime.Now.Year.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string GetYear(string year)
        {
            return year;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Json()
        {
            return Json(new { name = "omid", family = "nasri" });
        }
    }
}