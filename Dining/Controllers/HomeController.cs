using Dining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dining.Controllers
{
    public class HomeController : Controller
    {
        private DiningDbContext db = new DiningDbContext();
        // GET: Home
        public ActionResult Index()
        {
            List<menu> rs = db.menu.Select(m => m).ToList();
            return View(rs);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Event()
        {
            return View();
        }
        public ActionResult Contacect_us()
        {
            return View();
        }
        public ActionResult Stage_Door()
        {
            return View();
        }
        public string GetMTypeData(int mtype)
        {
            List<menu> menu = db.menu.Where(w => w.mtype == mtype).ToList();
            System.Web.Script.Serialization.JavaScriptSerializer jss = new System.Web.Script.Serialization.JavaScriptSerializer();
            return jss.Serialize(menu);
        }
        public string GetMenuData()
        {
            List<menu2> menu2 = db.menu2.ToList();
            System.Web.Script.Serialization.JavaScriptSerializer s = new System.Web.Script.Serialization.JavaScriptSerializer();
            return s.Serialize(menu2);
        }
    }
}