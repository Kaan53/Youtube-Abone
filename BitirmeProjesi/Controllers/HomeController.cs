using BitirmeProjesi.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeProjesi.Controllers
{

    public class HomeController : Controller
    {
        UserDBEntities db = new UserDBEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Abone()
        {
            var veri = db.Users.ToList();
            return View(veri);
        }
        [HttpPost]
        public ActionResult Abone(int kullanici, string YoutubeAbone)
        {
            var x = db.Users.Find(kullanici);
            x.Puan += 10;

            var kontrol = db.Users.FirstOrDefault(a => a.YoutubeAbone == YoutubeAbone);
            var y = db.Users.Find(kontrol.UserId);
            y.Puan -= 10;

            db.SaveChanges();
            return View();
        }
    }
}

