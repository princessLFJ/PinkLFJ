using Dining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dining.Controllers
{
    public class EmployeeController : Controller
    {
        DiningDbContext db = new DiningDbContext();
        // GET: Employee
        public ActionResult Index()
        {
            var r = db.employee;
            return View(r);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(employee e)
        {
            if (e.ename != null && e.eage != null && e.eimg != null && e.esalary != null)
            {
                db.employee.Add(e);
                db.SaveChanges();
                Response.Write("添加成功！");
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}