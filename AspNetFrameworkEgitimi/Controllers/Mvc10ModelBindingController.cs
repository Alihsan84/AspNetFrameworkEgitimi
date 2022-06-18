using AspNetFrameworkEgitimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFrameworkEgitimi.Controllers
{
    public class Mvc10ModelBindingController : Controller
    {
        // GET: Mvc10ModelBinding
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kullanici()
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Ali",
                Soyad = "Demirci",
                Email = "info@site.com",
                KullaniciAdi = "ali",
                Sifre = "123456",
            };
            return View(kullanici);
        }
        [HttpPost]
        public ActionResult Kullanici(Kullanici kullanici) //post metodunda ön yüzdem gönderilen modeli parametre ile elde edebiliriz.
        {
            ViewBag.Mesaj = "Kullanıcı Adı : " + kullanici.Ad;
            ViewData["Vdata"] = "Kullanıcı SoyAdı : " + kullanici.Soyad;
            TempData["Tdata"] = "Kullanıcı Email : " + kullanici.Email;
            return View(kullanici);//post işleminden sonra kullanici nensnesini sayfaya tekrar geri gönderebiliriz.
        }
        public ActionResult Adres()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adres(Adres adres)
        {
            ViewBag.Mesaj = "Şehir : " + adres.Sehir;
            ViewData["Vdata"] = "İlçe : " + adres.Ilce;
            TempData["Tdata"] = "Açık Adres : " + adres.AcikAdres;
            return View(adres);
        }
        public ActionResult UyeSayfasi()
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Ali",
                Soyad = "Demirci",
                Email = "info@site.com",
                KullaniciAdi = "ali",
                Sifre = "123456",
            };
            var model = new UyeSayfasiViewModel()
            {
                Kullanici = kullanici,
                Adres = new Adres { Sehir = "Hatay", Ilce = "Antakya", AcikAdres = "Kuruyer Köyü" }
            };
            return View(model);
        }
    }
         
}