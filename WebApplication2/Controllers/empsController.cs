using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class empsController : Controller
    {
        empEntities1 db = new empEntities1();
        // GET: main
        public ActionResult emps()
        {
            List<employee_salary_detail> data = db.employee_salary_detail.ToList();
            return View(data);
        }
        public ActionResult add()
        {
            return View();
        }

        public ActionResult addd(int id)
        {
            employee_salary_detail data = employee_salary_detail.Find(id);//find data using primary key
            return View(data);
        }

        public ActionResult Updatedata(employee_salary_detail employee_Salary_Detail)
        {
            db.Entry(employee_Salary_Detail).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("emps");
        }



        public ActionResult SaveData1(employee_salary_detail employee_Salary_Detail)
        {
            db.employee_salary_detail.Add(employee_Salary_Detail);
            db.SaveChanges();
            return RedirectToAction("emps");
        }
    }
}