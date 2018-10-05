using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hr_management.Models;

namespace hr_management.Controllers
{
    public class PolicyController : Controller
    {
        public ActionResult Initial()
        {
            return View();
        }
        // GET: Policy
        public ActionResult Policies()
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Policies.ToList());
            }
        }

        // GET: Policy/Details/5
        public ActionResult getPolicy(int id)
        {
             using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Policies.Where(x => x.PolicyId == id).FirstOrDefault());
            }
        }

        // GET: Policy/Create
        public ActionResult AddPolicy()
        {
            return View();
        }

        // POST: Policy/Create
        [HttpPost]
        public ActionResult AddPolicy(Policy pol)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.Policies.Add(pol);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Policies");
            }
            catch
            {
                return View();
            }
        }

        // GET: Policy/Edit/5
        public ActionResult UpdatePolicy(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Policies.Where(x => x.PolicyId == id).FirstOrDefault());
            }
        }

        // POST: Policy/Edit/5
        [HttpPost]
        public ActionResult UpdatePolicy(int id, Policy pol)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.Entry(pol).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Policies");
            }
            catch
            {
                return View();
            }
        }

        // GET: Policy/Delete/5
        public ActionResult DeletePolicy(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Policies.Where(x => x.PolicyId == id).FirstOrDefault());
            }
        }

        // POST: Policy/Delete/5
        [HttpPost]
        public ActionResult DeletePolicy(int id, FormCollection collection)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    Policy pol = db.Policies.Where(x => x.PolicyId == id).FirstOrDefault();
                    db.Policies.Remove(pol);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("Policies");
            }
            catch
            {
                return View();
            }
        }
    }
}
