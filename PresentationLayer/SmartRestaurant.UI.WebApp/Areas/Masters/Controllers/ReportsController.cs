using SmartRestaurant.Business;
using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartRestaurant.UI.WebApp.Controllers
{
    public class ReportsController : BaseController
    {
        // GET: Masters/Reports
        public ActionResult TodaysOrderReport()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TodaysOrderReport(RptOrderSearchModel data)
        {
            if (ModelState.IsValid)
            {
                TempData["LstOrderDetials"] = null;
                if (TempData["LstOrderDetials"] == null)
                {
                    data.LstOrderDetials = RptOrder.GetBillNotification(data.FromDate, data.ToDate);
                    TempData["LstOrderDetials"] = data.LstOrderDetials;
                }
                TempData["lstStatus"] = (List<string>)data.LstOrderDetials.Select(s => s.status).Distinct().ToList();

            }
            return View(data);

        }

        [HttpPost]
        public ActionResult OrderReportSearch(RptOrderSearchModel data)
        {
            if (ModelState.IsValid)
            {
                if (TempData["LstOrderDetials"] != null)
                {
                    var objLst = TempData["LstOrderDetials"] as List<RptOrderModel>;
                    if (data.Status != "0")
                    {
                        data.LstOrderDetials = objLst.Where(s => s.status.ToUpper().Contains(data.Status.ToUpper())).ToList();
                    }
                    else
                    {
                        data.LstOrderDetials = objLst;
                    }
                    
                    
                }                
                TempData.Keep();
            }

            return Json(data.LstOrderDetials, JsonRequestBehavior.AllowGet);
        }
    }
 
}
