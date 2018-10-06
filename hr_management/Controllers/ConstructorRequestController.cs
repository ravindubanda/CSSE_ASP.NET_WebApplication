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
    public class ConstructorRequestController : Controller
    {
        public ActionResult Initial()
        {
            return View();
        }
        // GET: ConstructorRequest
        public ActionResult getConRequest()
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.ConstructorRequests.ToList());
            }
        }

        // GET: ConstructorRequest/Details/5
        public ActionResult getRequestDetails(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.ConstructorRequests.Where(x => x.ConstructorRequestId == id).FirstOrDefault());
            }
        }

        // GET: ConstructorRequest/Create
        public ActionResult AddRequest()
        {
            return View();
        }

        // POST: ConstructorRequest/Create
        [HttpPost]
        public ActionResult AddRequest(ConstructorRequest cq)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.ConstructorRequests.Add(cq);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("getConRequest");
            }
            catch
            {
                return View();
            }
        }

        // GET: ConstructorRequest/Edit/5
        public ActionResult UpdateRequest(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.ConstructorRequests.Where(x => x.ConstructorRequestId == id).FirstOrDefault());
            }

        }

        // POST: ConstructorRequest/Edit/5
        [HttpPost]
        public ActionResult UpdateRequest(int id, ConstructorRequest cq)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.Entry(cq).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("getConRequest");
            }
            catch
            {
                return View();
            }
        }

        // GET: ConstructorRequest/Delete/5
        public ActionResult DeleteRequest(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.ConstructorRequests.Where(x => x.ConstructorRequestId == id).FirstOrDefault());
            }
        }

        // POST: ConstructorRequest/Delete/5
        [HttpPost]
        public ActionResult DeleteRequest(int id, FormCollection collection)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    ConstructorRequest cq = db.ConstructorRequests.Where(x => x.ConstructorRequestId == id).FirstOrDefault();
                    db.ConstructorRequests.Remove(cq);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("getConRequest");
            }
            catch
            {
                return View();
            }
        }
    }
}
