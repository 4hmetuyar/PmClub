using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PmClup.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Home Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Kurumsal
        /// </summary>
        /// <returns></returns>
        public ActionResult Corporate()
        {
            return View();
        }
    }
}