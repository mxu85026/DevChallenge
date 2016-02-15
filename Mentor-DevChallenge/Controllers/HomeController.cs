using Mentor_DevChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mentor_DevChallenge.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            PCPViewData pcpData = new PCPViewData();
            pcpData.TabTitles = (from t in db.TabTitles select t).ToList();
            pcpData.PrimaryProviders = (from p in db.PrimaryProvidersS select p).ToList();


            return View(pcpData);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}