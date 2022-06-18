using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFrameworkEgitimi.Controllers
{
    public class Mvc08ControllerToViewController : Controller
    {
        // GET: Mvc08ControllerToView : Mvc Controllerden View veri gönderme
        public ActionResult Index()
        {
            ViewBag.KategoriAdi = "Bilgisayar";
            ViewData["UrunAdi"] = "Lenova Tablet";
            TempData["UrunFiyati"] = "1990";
            return View();
        }
    }
}