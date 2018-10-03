using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hr_management.Models;

namespace hr_management.Controllers
{
    public class SiteController : Controller
    {
        public ActionResult Initial()
        {
            return View();
        }
        // GET: Site
        public ActionResult getSites()
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Sites.ToList());
            }
        }

        // GET: Site/Details/5
        public ActionResult getSiteDetails(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Sites.Where(x => x.SiteId == id).FirstOrDefault());
            }
        }

        // GET: Site/Create
        public ActionResult AddSites()
        {
            return View();
        }

        // POST: Site/Create
        [HttpPost]
        public ActionResult AddSites(Site site)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    db.Sites.Add(site);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("getSites");
            }
            catch
            {
                return View();
            }
        }

        // GET: Site/Edit/5
        public ActionResult UpdateSite(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Sites.Where(x => x.SiteId == id).FirstOrDefault());
            }
        }

        // POST: Site/Edit/5
        [HttpPost]
        public ActionResult UpdateSite(int id, Site site)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    db.Entry(site).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("getSites");
            }
            catch
            {
                return View();
            }
        }

        // GET: Site/Delete/5
        public ActionResult DeleteSite(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Sites.Where(x => x.SiteId == id).FirstOrDefault());
            }
        }

        // POST: Site/Delete/5
        [HttpPost]
        public ActionResult DeleteSite(int id, FormCollection collection)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    Site site = db.Sites.Where(x => x.SiteId == id).FirstOrDefault();
                    db.Sites.Remove(site);
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
