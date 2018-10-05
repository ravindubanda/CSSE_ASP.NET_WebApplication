using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hr_management.Models;

namespace hr_management.Controllers
{
    public class SupplierItemPriceController : Controller
    {
        public ActionResult Initial()
        {
            return View();
        }
        // GET: SupplierItemPrice
        public ActionResult getSupItemPrices()
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.SupplierItemPrices.ToList());
            }
        }

        // GET: SupplierItemPrice/Details/5
        public ActionResult getSupItemPriceDetails(int id)
        {

            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.SupplierItemPrices.Where(x => x.SupplierItemPriceId == id).FirstOrDefault());
            }
        }

        // GET: SupplierItemPrice/Create
        public ActionResult AddSupItemPrice()
        {
            SupplierItemPrice sip = new SupplierItemPrice();
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                sip.ItemCollection = db.Items.ToList<Item>();
            }
            return View(sip);
        }

        // POST: SupplierItemPrice/Create
        [HttpPost]
        public ActionResult AddSupItemPrice(SupplierItemPrice sip)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.SupplierItemPrices.Add(sip);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("getSupItemPrices");
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierItemPrice/Edit/5
        public ActionResult EditSupItemPrice(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.SupplierItemPrices.Where(x => x.SupplierItemPriceId == id).FirstOrDefault());
            }
        }

        // POST: SupplierItemPrice/Edit/5
        [HttpPost]
        public ActionResult EditSupItemPrice(int id, SupplierItemPrice sip)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.Entry(sip).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("getSupItemPrices");
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierItemPrice/Delete/5
        public ActionResult DeleteSupItemPrice(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.SupplierItemPrices.Where(x => x.SupplierItemPriceId == id).FirstOrDefault());
            }
        }

        // POST: SupplierItemPrice/Delete/5
        [HttpPost]
        public ActionResult DeleteSupItemPrice(int id, FormCollection collection)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    SupplierItemPrice sip = db.SupplierItemPrices.Where(x => x.SupplierItemPriceId == id).FirstOrDefault();
                    db.SupplierItemPrices.Remove(sip);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("getSupItemPrices");
            }
            catch
            {
                return View();
            }
        }
    }
}
