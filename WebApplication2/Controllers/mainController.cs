using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class mainController : Controller
    {
        empEntities1 db = new empEntities1();
        // GET: main
        public ActionResult Index()
        {
            List<Table_1> data = db.Table_1.ToList();
            return View(data);
        }
        public ActionResult create()
        {
            return View();
        }

        public ActionResult Savedata(Table_1 table_1)
        {
            db.Table_1.Add(table_1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}