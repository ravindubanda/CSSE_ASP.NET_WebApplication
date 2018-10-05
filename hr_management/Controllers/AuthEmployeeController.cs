using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hr_management.Models;

namespace hr_management.Controllers
{
    public class AuthEmployeeController : Controller
    {
        public ActionResult Main()
        {
            return View();
        }

        public ActionResult Initial()
        {
            return View();
        }
        // GET: AuthEmployee
        public ActionResult getEmployees()
        {
           using(sithar_dbEntities1 db=new sithar_dbEntities1())
            {
                return View(db.AuthEmployees.ToList());
            }
        }

        // GET: AuthEmployee/Details/5
        public ActionResult getdetails(int id)
        {
            using(sithar_dbEntities1 db=new sithar_dbEntities1())
            {
                return View(db.AuthEmployees.Where(x => x.AuthEmployeeId == id).FirstOrDefault());
            }
        }

        // GET: AuthEmployee/Create
        public ActionResult AddEmployee()
        {
            return View();
        }

        // POST: AuthEmployee/Create
        [HttpPost]
        public ActionResult AddEmployee(AuthEmployee emp)
        {
            try
            {
                using(sithar_dbEntities1 db=new sithar_dbEntities1())
                {
                    db.AuthEmployees.Add(emp);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Initial");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthEmployee/Edit/5
        public ActionResult UpdateEmployee(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.AuthEmployees.Where(x => x.AuthEmployeeId == id).FirstOrDefault());
            }
        }
    

        // POST: AuthEmployee/Edit/5
        [HttpPost]
        public ActionResult UpdateEmployee(int id, AuthEmployee emp)
        {
            try
            {
                using(sithar_dbEntities1 db=new sithar_dbEntities1())
                {
                    db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Initial");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthEmployee/Delete/5
        public ActionResult DeleteEmployee(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.AuthEmployees.Where(x => x.AuthEmployeeId == id).FirstOrDefault());
            }
        }

        // POST: AuthEmployee/Delete/5
        [HttpPost]
        public ActionResult DeleteEmployee(int id, FormCollection collection)
        {
            try
            {
                using (sithar_dbEntities1 db=new sithar_dbEntities1())
                {
                    AuthEmployee emp = db.AuthEmployees.Where(x => x.AuthEmployeeId == id).FirstOrDefault();
                    db.AuthEmployees.Remove(emp);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("Initial");
            }
            catch
            {
                return View();
            }
        }
    }
}
