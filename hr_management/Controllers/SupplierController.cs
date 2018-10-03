using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hr_management.Models;

namespace hr_management.Controllers
{
    public class SupplierController : Controller
    {
        // GET: Supplier
        public ActionResult getSuppliers()
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Suppliers.ToList());
            }
        }

        // GET: Supplier/Details/5
        public ActionResult getSupplier(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Suppliers.Where(x => x.SupplierId == id).FirstOrDefault());
            }

        }

        // GET: Supplier/Create
        public ActionResult AddSupplier()
        {
            return View();
        }

        // POST: Supplier/Create
        [HttpPost]
        public ActionResult AddSupplier(Supplier sup)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    db.Suppliers.Add(sup);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("getSuppliers");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Edit/5
        public ActionResult UpdateSupplier(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Suppliers.Where(x => x.SupplierId == id).FirstOrDefault());
            }
        }

        // POST: Supplier/Edit/5
        [HttpPost]
        public ActionResult UpdateSupplier(int id, Supplier sup)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    db.Entry(sup).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("getSuppliers");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Delete/5
        public ActionResult DeleteSupplier(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Suppliers.Where(x => x.SupplierId == id).FirstOrDefault());
            }
        }

        // POST: Supplier/Delete/5
        [HttpPost]
        public ActionResult DeleteSupplier(int id, FormCollection collection)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    Supplier sup = db.Suppliers.Where(x => x.SupplierId == id).FirstOrDefault();
                    db.Suppliers.Remove(sup);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("getSuppliers");
            }
            catch
            {
                return View();
            }
        }
    }
}
