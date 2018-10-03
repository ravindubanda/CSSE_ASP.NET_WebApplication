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
        public ActionResult ViewPolicies()
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Policies.ToList());
            }
        }

        // GET: Policy/Details/5
        public ActionResult ViewPolicy(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Policies.Where(x => x.PolicyId == id).FirstOrDefault());
            }
        }

        // GET: Policy/Create
        public ActionResult CreatePolicy()
        {
            return View();
        }

        // POST: Policy/Create
        [HttpPost]
        public ActionResult CreatePolicy(Policy pol)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    db.Policies.Add(pol);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("ViewPolicies");
            }
            catch
            {
                return View();
            }
        }

        // GET: Policy/Edit/5
        public ActionResult UpdatePolicy(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Policies.Where(x => x.PolicyId== id).FirstOrDefault());
            }
        }

        // POST: Policy/Edit/5
        [HttpPost]
        public ActionResult UpdatePolicy(int id, Policy pol)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    db.Entry(pol).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("ViewPolicies");
            }
            catch
            {
                return View();
            }
        }

        // GET: Policy/Delete/5
        public ActionResult DeletePolicy(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
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
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    Policy pol = db.Policies.Where(x => x.PolicyId == id).FirstOrDefault();
                    db.Policies.Remove(pol);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("ViewPolicies");
            }
            catch
            {
                return View();
            }
        }
    }
}
