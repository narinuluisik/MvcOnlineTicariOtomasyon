﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Siniflar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.SatisHarekets.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
            List<SelectListItem> deger1 = (from x in c.Uruns.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.UrunAd,
                                               Value = x.Urunid.ToString()
                                           }).ToList();

            List<SelectListItem> deger2 = (from x in c.Carilers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CariAd+" "+x.CariSoyad,
                                               Value = x.Cariid.ToString()
                                           }).ToList();


            List<SelectListItem> deger3 = (from x in c.Personels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAd+" "+x.PersonelSoyad,
                                               Value = x.Personelid.ToString()
                                           }).ToList();
         
            ViewBag.dgr1 = deger1;
            ViewBag.dgr2 = deger2;
            ViewBag.dgr3 = deger3;
            return View();
        }

        [HttpPost]
        public ActionResult YeniSatis(SatisHareket s)
        {
            s.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.SatisHarekets.Add(s);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult SatisGetir(int id)

        {

            List<SelectListItem> deger1 = (from x in c.Uruns.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.UrunAd,
                                               Value = x.Urunid.ToString()
                                           }).ToList();

            List<SelectListItem> deger2 = (from x in c.Carilers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CariAd + " " + x.CariSoyad,
                                               Value = x.Cariid.ToString()
                                           }).ToList();


            List<SelectListItem> deger3 = (from x in c.Personels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAd + " " + x.PersonelSoyad,
                                               Value = x.Personelid.ToString()
                                           }).ToList();

            ViewBag.dgr1 = deger1;
            ViewBag.dgr2 = deger2;
            ViewBag.dgr3 = deger3;
            var satis = c.SatisHarekets.Find(id);

            return View("SatisGetir", satis);
        }

        public ActionResult SatisGüncelle(SatisHareket s)
        {
            var sts = c.SatisHarekets.Find(s.Satisid);
            sts.Cariid = s.Cariid;
            sts.Adet = s.Adet;
            sts.Fiyat = s.Fiyat;
            sts.Personelid = s.Personelid;
            sts.Tarih = s.Tarih;
            sts.ToplamTutar = s.ToplamTutar;
            sts.Urunid = s.Urunid;
            c.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult SatisDetay(int id)
        {
            var degerler = c.SatisHarekets.Where(x => x.Satisid == id).ToList();
         

            return View(degerler);
        }
    }
}