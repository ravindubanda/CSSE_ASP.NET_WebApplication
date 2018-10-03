using hr_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hr_management.Controllers
{
    public class SiteItemQuantityController : Controller
    {
        // GET: SiteItemQuantity
        public ActionResult getQuantities()
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.SiteItemQuantities.ToList());
            }
        }
      //  [HttpPost]
      //  public ActionResult getQuantities(int SID, SiteItemQuantity siq)
      //  {
       //     using (sithar_dbEntities db = new sithar_dbEntities())
       //     {
       //         var qty=db.SiteItemQuantities.ToList().Where(x => x.SiteID==SID).FirstOrDefault();
       //         return View(qty);
        //    }
        //}

        // GET: SiteItemQuantity/Details/5
        public ActionResult getQuantity(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.SiteItemQuantities.Where(x => x.SiteItemQuantityId == id).FirstOrDefault());
            }
        }

        // GET: SiteItemQuantity/Create
        public ActionResult AddQty()
        {
           // SiteItemQuantity siq = new SiteItemQuantity();
          //  using(sithar_dbEntities db=new sithar_dbEntities())
           // {
          //      siq.ItemCollection = db.Items.ToList<Item>();
          //  }
            return View();
        }

        // POST: SiteItemQuantity/Create
        [HttpPost]
        public ActionResult AddQty(SiteItemQuantity siq)
        {
            try
            {
               
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                   
                    db.SiteItemQuantities.Add(siq);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("getQuantities");
            }
            catch
            {
                return View();
            }
        }

        // GET: SiteItemQuantity/Edit/5
        public ActionResult UpdateQty(int id)
        {
            using (sithar_dbEntities db = new sithar_dbEntities())
            {
                return View(db.SiteItemQuantities.Where(x => x.SiteItemQuantityId == id).FirstOrDefault());
            }
        }

        // POST: SiteItemQuantity/Edit/5
        [HttpPost]
        public ActionResult UpdateQty(int id, SiteItemQuantity siq)
        {
            try
            {
                using (sithar_dbEntities db = new sithar_dbEntities())
                {
                    db.Entry(siq).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("getQuantities");
            }
            catch
            {
                return View();
            }
        }




    }
}
