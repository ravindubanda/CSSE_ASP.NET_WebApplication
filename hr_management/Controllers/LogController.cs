using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hr_management.Models;

namespace hr_management.Controllers
{
    public class LogController : Controller
    {
        public ActionResult Initial()
        {
            return View();
        }
        // GET: Log
        public ActionResult getLogs()
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Logs.ToList());
            }
        }

        // GET: Log/Details/5
        public ActionResult LogDetails(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Logs.Where(x => x.LogId == id).FirstOrDefault());
            }
        }

        // GET: Log/Create
        public ActionResult AddLog()
        {
            return View();
        }

        // POST: Log/Create
        [HttpPost]
        public ActionResult AddLog(Log log)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.Logs.Add(log);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("getLogs");
            }
            catch
            {
                return View();
            }
        }

        // GET: Log/Edit/5
        public ActionResult EditLog(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Logs.Where(x => x.LogId == id).FirstOrDefault());
            }
        }

        // POST: Log/Edit/5
        [HttpPost]
        public ActionResult EditLog(int id, Log log)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.Entry(log).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("getLogs");
            }
            catch
            {
                return View();
            }
        }

        // GET: Log/Delete/5
        public ActionResult DeleteLog(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.Logs.Where(x => x.LogId == id).FirstOrDefault());
            }
        }

        // POST: Log/Delete/5
        [HttpPost]
        public ActionResult DeleteLog(int id, FormCollection collection)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    Log log = db.Logs.Where(x => x.LogId == id).FirstOrDefault();
                    db.Logs.Remove(log);
                    db.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("getLogs");
            }
            catch
            {
                return View();
            }
        }
    }
}
