using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hr_management.Models;
using hr_management.ViewModel;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace hr_management.Controllers
{
    [Authorize]
    public class ShowDataController : Controller
    {
        // GET: ShowData
        public ActionResult MultiData()
        {
            sithar_dbEntities1 obj = new sithar_dbEntities1();
            var MyModel = new Multiple();
            MyModel.pol = obj.Policies.ToList();
            MyModel.conreq = obj.ConstructorRequests.ToList();

            return View(MyModel);
        }


       

        [HttpPost]
        public ActionResult saveuser(int id, string propertyName, string value)
        {
            var status = false;
            var message = "";
            //Update data to database

            using (sithar_dbEntities1 dc = new sithar_dbEntities1())
            {
               
                var user = dc.ConstructorRequests.Find(id);
                if (user != null)
                {
                    dc.Entry(user).Property(propertyName).CurrentValue = value;
                    dc.SaveChanges();
                    status = true;
                }
                else
                {
                    message = "Error!";
                }
            }

            var response = new { value = value, status = status, message = message };
            JObject o = JObject.FromObject(response);
            return Content(o.ToString());
        }




    }
}