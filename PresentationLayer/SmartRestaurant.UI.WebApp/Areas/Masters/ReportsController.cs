using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartRestaurant.UI.WebApp.Areas.Masters
{
    public class ReportsController : Controller
    {
        // GET: Masters/Reports
        public ActionResult TodaysOrderReport()
        {
            return View();
        }
    }
 
}
