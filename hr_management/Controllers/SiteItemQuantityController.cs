using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hr_management.Models;
using hr_management.ViewModel;
using Newtonsoft.Json.Linq;

namespace hr_management.Controllers
{
    public class SiteItemQuantityController : Controller
    {
        public ActionResult Initial()
        {
            return View();
        }
       
        // GET: SiteItemQuantity
        public ActionResult SiteItemQty()
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.SiteItemQuantities.ToList());
            }
        }

        // GET: SiteItemQuantity/Details/5
        public ActionResult SiteItemQtyDetails(int id)
        {
            using(sithar_dbEntities1 db=new sithar_dbEntities1())
            {
                return View(db.SiteItemQuantities.Where(x => x.SiteItemQuantityId == id).FirstOrDefault());
            }
        }

        // GET: SiteItemQuantity/Create
        public ActionResult AddSiteItemQty()
        {
            SiteItemQuantity siq = new SiteItemQuantity();
            using (sithar_dbEntities1 db=new sithar_dbEntities1())
            {
                siq.ItemCollection = db.Items.ToList<Item>();
            }
                return View(siq);
        }

        // POST: SiteItemQuantity/Create
        [HttpPost]
        public ActionResult AddSiteItemQty(SiteItemQuantity siq)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.SiteItemQuantities.Add(siq);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("SiteItemQty");
            }
            catch
            {
                return View();
            }
        }

        // GET: SiteItemQuantity/Edit/5
        public ActionResult UpdateSiteItemQty(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.SiteItemQuantities.Where(x => x.SiteItemQuantityId == id).FirstOrDefault());
            }
        }

        // POST: SiteItemQuantity/Edit/5
        [HttpPost]
        public ActionResult UpdateSiteItemQty(int id, SiteItemQuantity siq)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.Entry(siq).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("SiteItemQty");
            }
            catch
            {
                return View();
            }
        }

        // GET: SiteItemQuantity/Delete/5
        public ActionResult DeleteSiteItemQty(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.SiteItemQuantities.Where(x => x.SiteItemQuantityId == id).FirstOrDefault());
            }
        }

        // POST: SiteItemQuantity/Delete/5
        [HttpPost]
        public ActionResult DeleteSiteItemQty(int id, FormCollection collection)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    SiteItemQuantity siq = db.SiteItemQuantities.Where(x => x.SiteItemQuantityId == id).FirstOrDefault();
                    db.SiteItemQuantities.Remove(siq);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("SiteItemQty");
            }
            catch
            {
                return View();
            }
        }
    }
}
