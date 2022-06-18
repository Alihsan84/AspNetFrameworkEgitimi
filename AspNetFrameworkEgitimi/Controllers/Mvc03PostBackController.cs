using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFrameworkEgitimi.Controllers
{
    public class Mvc03PostBackController : Controller
    {
        // GET: Mvc03PostBack
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string text)
        {
            return View();
        }
    }
}