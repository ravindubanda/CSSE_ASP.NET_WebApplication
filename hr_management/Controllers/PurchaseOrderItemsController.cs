using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hr_management.Models;
using System.ComponentModel.DataAnnotations;


namespace hr_management.Controllers
{
    [Authorize]
    public class PurchaseOrderItemsController : Controller
    {
        public ActionResult Initial()
        {
            return View();
        }
        // GET: PurchaseOrderItems
        public ActionResult PurchaseItems()
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.PurchaseOrderItems.ToList());
            }
        }

        // GET: PurchaseOrderItems/Details/5
        public ActionResult PurchaseItemDetails(int id)
        {

            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.PurchaseOrderItems.Where(x => x.PurchaseOrderItemsId == id).FirstOrDefault());
            }
        }

        // GET: PurchaseOrderItems/Create
        public ActionResult AddPurchaseItem()
        {
            PurchaseOrderItem poi = new PurchaseOrderItem();
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                poi.ItemCollection = db.Items.ToList<Item>();
            }
            return View(poi);
        }

        // POST: PurchaseOrderItems/Create
        [HttpPost]
        public ActionResult AddPurchaseItem(PurchaseOrderItem poi)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.PurchaseOrderItems.Add(poi);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("PurchaseItems");
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseOrderItems/Edit/5
        public ActionResult UpdatePurchaseItem(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.PurchaseOrderItems.Where(x => x.PurchaseOrderItemsId == id).FirstOrDefault());
            }
        }

        // POST: PurchaseOrderItems/Edit/5
        [HttpPost]
        public ActionResult UpdatePurchaseItem(int id, PurchaseOrderItem poi)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.Entry(poi).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("PurchaseItems");
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseOrderItems/Delete/5
        public ActionResult DeletePurchaseItems(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.PurchaseOrderItems.Where(x => x.PurchaseOrderItemsId == id).FirstOrDefault());
            }
        }

        // POST: PurchaseOrderItems/Delete/5
        [HttpPost]
        public ActionResult DeletePurchaseItems(int id, FormCollection collection)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    PurchaseOrderItem poi = db.PurchaseOrderItems.Where(x => x.PurchaseOrderItemsId == id).FirstOrDefault();
                    db.PurchaseOrderItems.Remove(poi);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("PurchaseItems");
            }
            catch
            {
                return View();
            }
        }
    }
}
