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
    }
}