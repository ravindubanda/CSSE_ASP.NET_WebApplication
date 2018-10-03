using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hr_management.Models;

namespace hr_management.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult getItems()
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Items.ToList());
            }
        }

        // GET: Item/Details/5
        public ActionResult getItemDetails(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Items.Where(x => x.ItemId == id).FirstOrDefault());
            }
        }

        // GET: Item/Create
        public ActionResult AddItem()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult AddItem(Item item)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    db.Items.Add(item);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("getItems");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Edit/5
        public ActionResult UpdateItem(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Items.Where(x => x.ItemId == id).FirstOrDefault());
            }
        }

        // POST: Item/Edit/5
        [HttpPost]
        public ActionResult UpdateItem(int id, Item item)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("getItems");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult DeleteItem(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.Items.Where(x => x.ItemId == id).FirstOrDefault());
            }
        }

        // POST: Item/Delete/5
        [HttpPost]
        public ActionResult DeleteItem(int id, FormCollection collection)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    Item item = db.Items.Where(x => x.ItemId == id).FirstOrDefault();
                    db.Items.Remove(item);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("getItems");
            }
            catch
            {
                return View();
            }
        }
    }
}
