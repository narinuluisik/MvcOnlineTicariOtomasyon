using MvcOnlineTicariOtomasyon.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Partial1(Cariler p)
        {
            c.Carilers.Add(p);
            c.SaveChanges();
            return PartialView();
        }
        [HttpGet]
        public ActionResult CariLogin1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CariLogin1(Cariler ca)
        {
            var bilgi = c.Carilers.FirstOrDefault
            (x => x.CariMail == ca.CariMail && x.CariSifre == ca.CariSifre);
            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.CariMail, false);
                Session["CariMail"] = bilgi.CariMail.ToString();
                return RedirectToAction("Index", "CariPanel");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }
        [HttpGet]
        public ActionResult LoginAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginAdmin(Admin p)
        {
            var bilgi = c.Admins.FirstOrDefault(x=>x.KullaniciAd == p.KullaniciAd && x.Sifre == p.Sifre);

            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.KullaniciAd, false);
                Session["KullaniciAd"] = bilgi.KullaniciAd.ToString();
                return RedirectToAction("Index", "Kategori");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }
    } }                                      