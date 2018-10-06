using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hr_management.Models;
using System.ComponentModel.DataAnnotations;

namespace hr_management.Controllers
{
    public class SiteController : Controller
    {
        [Authorize]
        public ActionResult Initial()
        {
            return View();
        }
        // GET: Site
        public ActionResult Sites()
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Sites.ToList());
            }
        }

        // GET: Site/Details/5
        public ActionResult SiteDetails(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Sites.Where(x => x.SiteId == id).FirstOrDefault());
            }
        }

        // GET: Site/Create
        public ActionResult AddSite()
        {
            return View();
        }

        // POST: Site/Create
        [HttpPost]
        public ActionResult AddSite(Site site)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.Sites.Add(site);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Sites");
            }
            catch
            {
                return View();
            }
        }

        // GET: Site/Edit/5
        public ActionResult UpdateSite(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
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
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.Entry(site).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Sites");
            }
            catch
            {
                return View();
            }
        }

        // GET: Site/Delete/5
        public ActionResult DeleteSite(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
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
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    Site site = db.Sites.Where(x => x.SiteId == id).FirstOrDefault();
                    db.Sites.Remove(site);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("Sites");
            }
            catch
            {
                return View();
            }
        }
    }
}
