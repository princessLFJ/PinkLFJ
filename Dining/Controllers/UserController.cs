using Dining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dining.Controllers
{
    public class UserController : Controller
    {
        DiningDbContext db = new DiningDbContext();
        // GET: User
        public ActionResult Index()
        {
            var re = db.Manage;
            return View(re);
        }
        public ActionResult LoginIndex()
        {
            var r = db.Manage;
            return View(r);
        }
        public ActionResult Login(string UserName, string Password)
        {
            var re = db.Manage.Where(w => w.name.Equals(UserName) && w.pwd.Equals(Password));
            if (re.ToList().Count>0)
            {
                return RedirectToAction("LoginIndex");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public ActionResult Edit(int id)
        {
            var r = db.Manage.Find(id);
            Session["manageId"] = id;
            return View(r);
        }
        [HttpPost]
        public ActionResult Edit(Manage m)
        {
            var r = db.Manage.Find(Session["manageId"]);
            UpdateModel(r);
            db.SaveChanges();
            Session["manageId"] = null;
            Response.Write("<script>alert('修改成功')<script>");
            return RedirectToAction("LoginIndex");
        }
        public ActionResult Delete(int id)
        {
            var r = db.Manage.Find(id);
            var e = db.Manage.Remove(r);
            db.SaveChanges();
            Response.Write("<script>alert('删除成功')<script>");
            return RedirectToAction("LoginIndex");
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Manage m)
        {
            if(m.name!=""&&m.pwd!="")
            {
                db.Manage.Add(m);
                db.SaveChanges();
                Response.Write("添加成功");
                return RedirectToAction("LoginIndex");
            }
            else
            {
                Response.Write("请输入");
                return View();
            }
        }
    }
}