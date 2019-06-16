using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uygulama.Models.Context;
using Uygulama.Models.Entity;
using FluentValidation.Results;
using Uygulama.App_Class;

namespace Uygulama.Controllers
{
    public class BilgiController : Controller
    {

        CodeFirstContext db = new CodeFirstContext();
       
        // GET: Bilgi
        public ActionResult Index()
        {
            List<string> il = new List<string>
            {
                "adana",
                "istanbul",
                "ankara"
            };

        
            ViewBag.IL = il;

            return View();

        }

        [HttpPost]
        public ActionResult Index(Kullanici k)
        {

            var validator = new KullaniciValidator();

            var result = validator.Validate(k);

            if (result.Errors.Count > 0)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View(k);

            }

            db.Kullanicilar.Add(k);
            db.SaveChanges();

            return RedirectToAction("Listele");
        }


        public ActionResult Listele()
        {
            var kullanicilar = db.Kullanicilar.ToList();
            var borc = db.Kullanicilar.Where(x => x.BorcluMu == true).Sum(x=>x.Tutar);
            ViewBag.Borc = borc;
            return View(kullanicilar);
        }
    }
}