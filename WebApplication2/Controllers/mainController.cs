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

        public ActionResult Edit(int id)
        {
            Table_1 data = db.Table_1.Find(id);//find data using primary key
            return View(data);
        }

        public ActionResult Updatedata(Table_1 table_1)
        {
            db.Entry(table_1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult SaveData(Table_1 table_1)
        {
            db.Table_1.Add(table_1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}