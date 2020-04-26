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
        public ActionResult Abone(User u,int Puan)
        {
            return View();
        }
    }
}

