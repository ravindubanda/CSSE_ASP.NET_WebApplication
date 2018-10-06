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
    public class PurchaseOrderController : Controller
    {

        public ActionResult Initial()
        {
            return View();
        }
        // GET: PurchaseOrder
        public ActionResult Orders()
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.PurchaseOrders.ToList());
            }
        }

        // GET: PurchaseOrder/Details/5
        public ActionResult OrderDetails(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.PurchaseOrders.Where(x => x.PurchaseOrderId == id).FirstOrDefault());
            }
        }

        // GET: PurchaseOrder/Create
        public ActionResult AddOrder()
        {
            return View();
        }

        // POST: PurchaseOrder/Create
        [HttpPost]
        public ActionResult AddOrder(PurchaseOrder po)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.PurchaseOrders.Add(po);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Orders");
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseOrder/Edit/5
        public ActionResult UpdateOrder(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.PurchaseOrders.Where(x => x.PurchaseOrderId == id).FirstOrDefault());
            }
        }

        // POST: PurchaseOrder/Edit/5
        [HttpPost]
        public ActionResult UpdateOrder(int id, PurchaseOrder po)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.Entry(po).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Orders");
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseOrder/Delete/5
        public ActionResult DeleteOrder(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.PurchaseOrders.Where(x => x.PurchaseOrderId == id).FirstOrDefault());
            }
        }

        // POST: PurchaseOrder/Delete/5
        [HttpPost]
        public ActionResult DeleteOrder(int id, FormCollection collection)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    PurchaseOrder po = db.PurchaseOrders.Where(x => x.PurchaseOrderId == id).FirstOrDefault();
                    db.PurchaseOrders.Remove(po);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("Orders");
            }
            catch
            {
                return View();
            }
        }
    }
}
