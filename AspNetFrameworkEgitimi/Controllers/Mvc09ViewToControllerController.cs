using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFrameworkEgitimi.Controllers
{
    public class Mvc09ControllerToViewController : Controller
    {
        // GET: Mvc09ControllerToView
        public ActionResult Index(String txtAra) // mvc de index metodu içerisine bu şekilde parametre ekleyerek ön yüzden gönderilen
            //veriyi yakalayabiliyoruz Dikkat eşleşme sağlanabilmesi için ön yüzdeki elemanın name bilgisi ileburadaki değişken bilgisinin aynı isimde olması lazım yoksa eşlemez.
        {
            ViewBag.GetVerisi = "Aranan kelime : " + txtAra;
            return View();
        }
        [HttpPost] // aşağıdaki metodun sadece post işleminde çalışmasını sağlar.
        public ActionResult Index(string text1, string ddListe, bool cbOnay)
        {
            //1. yöntem parametrelerden gelen veri;
            ViewBag.Mesaj = "textboxdan gelen veri : " + text1;
            ViewData["Vdata"] = "checkboxdan gelen veri : " + cbOnay;
            TempData["Tdata"] = "listboxtan gelen veri : " + ddListe;

            //2. yöntem Requst.Form ile sayfadaki elemenlerden veri alma
            var txt = Request.Form["text1"];
            var ddl = Request.Form["ddListe"];
            // var chb = Request.Form["cbonay"]; true, false dönüyor.
            var chb = Request.Form.GetValues("cbonay")[0];

            ViewBag.Mesaj2 = "textboxdan gelen veri 2 : " + text1;
            ViewData["Vdata2"] = "checkboxdan gelen veri 2 : " + chb;
            TempData["Tdata2"] = "listboxtan gelen veri 2 : " + ddl;

            return View();
        }
    }
        
}