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
    public class ItemController : Controller
    {
        public ActionResult Initial()
        {
            return View();
        }
        // GET: Item
        public ActionResult getItems()
        {

            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Items.ToList());
            }
        }

        // GET: Item/Details/5
        public ActionResult ItemDetails(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Items.Where(x => x.ItemId == id).FirstOrDefault());
            }
        }

        // GET: Item/Create
        public ActionResult AddItems()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult AddItems(Item item)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
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
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
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
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
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
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
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
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
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
