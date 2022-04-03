using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class bookController : Controller
    {
        empEntities1 db = new empEntities1();
        // GET: book
        public ActionResult book()
        {
            List<Table_3> data = db.Table_3.ToList();
            return View(data);
        }
        public ActionResult Edit(int Bid)
        {
            Table_3 data = db.Table_3.Find(Bid);//find data using primary key
            return View(data);
        }


    }
}