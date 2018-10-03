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
        public ActionResult initial()
        {
            return View();
        }

        // GET: AuthEmployee
        public ActionResult Index()
        {
            using (sithar_dbEntities db =new sithar_dbEntities())
            {
                return View("Index",db.AuthEmployees.ToList());
            }
            
        }

        // GET: AuthEmployee/Details/5
        public ActionResult Details(int id)
        {
            using (sithar_dbEntities db=new sithar_dbEntities())
            {
                return View(db.AuthEmployees.Where(x=>x.AuthEmployeeId==id).FirstOrDefault());
            }
            
            
        }

        // GET: AuthEmployee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthEmployee/Create
        [HttpPost]
        public ActionResult Create(AuthEmployee emp)
        {
            try
            {
                using (sithar_dbEntities db=new sithar_dbEntities())
                {
                    db.AuthEmployees.Add(emp);
                    db.SaveChanges();
                }
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthEmployee/Edit/5
        public ActionResult Edit(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.AuthEmployees.Where(x => x.AuthEmployeeId == id).FirstOrDefault());
            }
        }

        // POST: AuthEmployee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AuthEmployee emp)
        {
            try
            {
                using (sithar_dbEntities db=new sithar_dbEntities())
                {
                    db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthEmployee/Delete/5
        public ActionResult Delete(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.AuthEmployees.Where(x => x.AuthEmployeeId == id).FirstOrDefault());
            }
        }

        // POST: AuthEmployee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using(sithar_dbEntities db=new sithar_dbEntities())
                {
                    AuthEmployee emp = db.AuthEmployees.Where(x => x.AuthEmployeeId == id).FirstOrDefault();
                    db.AuthEmployees.Remove(emp);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
