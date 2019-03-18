using Dining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dining.Controllers
{
    public class ManageController : Controller
    {
        DiningDbContext db = new DiningDbContext();
        // GET: Manage
        public ActionResult Index()
        {
            var d = db.menu;
            return View(d);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(menu m)
        {
            if (m.mname != null && m.mprice != null && m.mtype!=null)
            {
                db.menu.Add(m);
                db.SaveChanges();
                Response.Write("添加成功！");
                return RedirectToAction("Index");
            }
            else
            {
                Response.Write("请填写完整");
                return View();
            }

        }
        public ActionResult Delete(int id)
        {
            var r=db.menu.Find(id);
            db.menu.Remove(r);
            db.SaveChanges();
            Response.Write("删除成功");
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var r = db.menu.Find(id);
            Session["id"] = id;
            return View(r);
        }
        [HttpPost]
        public ActionResult Edit()
        {
            var r = db.menu.Find(Session["id"]);
            UpdateModel(r);
            db.SaveChanges();
            Response.Write("修改成功");
            return RedirectToAction("Index");
        }
    }
}