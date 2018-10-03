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
        // GET: SupplierItemPrice
        public ActionResult ViewPrices()
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.SupplierItemPrices.ToList());
            }
        }

        // GET: SupplierItemPrice/Details/5
        public ActionResult ViewPrice(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.SupplierItemPrices.Where(x => x.SupplierItemPriceId == id).FirstOrDefault());
            }
        }

        // GET: SupplierItemPrice/Create
        public ActionResult AddPrice()
        {
            return View();
        }

        // POST: SupplierItemPrice/Create
        [HttpPost]
        public ActionResult AddPrice(SupplierItemPrice sip)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    db.SupplierItemPrices.Add(sip);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("ViewPrices");
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierItemPrice/Edit/5
        public ActionResult UpdatePrice(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.SupplierItemPrices.Where(x => x.SupplierItemPriceId == id).FirstOrDefault());
            }
        }

        // POST: SupplierItemPrice/Edit/5
        [HttpPost]
        public ActionResult UpdatePrice(int id, SupplierItemPrice sip)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    db.Entry(sip).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("ViewPrices");
            }
            catch
            {
                return View();
            }
        }



       

    }
}
