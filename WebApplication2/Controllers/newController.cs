using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class newController : Controller
    {
        empEntities1 db = new empEntities1();
        // GET: main
        public ActionResult sub()
        {
            List<Table_2> data = db.Table_2.ToList();
            return View(data);
        }
        public ActionResult cret()
        {
            return View();
        }
        public ActionResult editt(int id)
        {
            Table_2 data = db.Table_2.Find(id);//find data using primary key
            return View(data);
        }
        public ActionResult Updatedata1(Table_2 table_2)
        {
            db.Entry(table_2).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("sub");
        }
        public ActionResult SaveData(Table_2 table_2)
        {
            db.Table_2.Add(table_2);
            db.SaveChanges();
            return RedirectToAction("sub");
        }
    }
}