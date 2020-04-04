using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace auth.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkında()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult KullanıcıGirisi()
        {

            return View();
        }

        public ActionResult Randevu()
        {

            return View();
        }

        public ActionResult BizeUlasın()
        {

            return View();
        }

        public ActionResult BizeUlas()
        {

            return View();
        }

        public ActionResult Doktorlar()
        {

            return View();
        }

        public ActionResult RandevuAl()
        {

            return View();
        }

        public ActionResult KullanıcıGiris()
        {

            return View();
        }

        public ActionResult KullanıcıEkranı()
        {

            return View();
        }
        public ActionResult ilacHatırlatıcı()
        {

            return View();
        }

        public ActionResult TahlilSorgulama()
        {

            return View();
        }
        public ActionResult BlogSayfası()
        {

            return View();
        }
        public ActionResult SingleBlogSayfası()
        {

            return View();
        }
    }
}