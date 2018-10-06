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
    public class GoodReceiptController : Controller
    {
        public ActionResult Initial()
        {
            return View();
        }
        // GET: GoodReceipt
        public ActionResult getReceipts()
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.GoodReceipts.ToList());
            }
        }

        // GET: GoodReceipt/Details/5
        public ActionResult getDetails(int id)
        {
            using (sithar_dbEntities1 db = new sithar_dbEntities1())
            {
                return View(db.GoodReceipts.Where(x => x.GoodReceiptId == id).FirstOrDefault());
            }
        }

        // GET: GoodReceipt/Create
        public ActionResult IssueReceipt()
        {
            return View();
        }

        // POST: GoodReceipt/Create
        [HttpPost]
        public ActionResult IssueReceipt(GoodReceipt gr)
        {
            try
            {
                using (sithar_dbEntities1 db = new sithar_dbEntities1())
                {
                    db.GoodReceipts.Add(gr);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Initial");
            }
            catch
            {
                return View();
            }
        }


       

    }
}
