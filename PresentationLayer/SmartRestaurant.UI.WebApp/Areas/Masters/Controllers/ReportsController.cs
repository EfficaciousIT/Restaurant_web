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

        public ActionResult DataTable()
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
                TempData["lstMenu"] = (List<string>)data.LstOrderDetials.Select(s => s.Menu_Name).Distinct().ToList();

                var list = data.LstOrderDetials.Select(s => new { Code = s.Employee_Id, Name = s.Employee_Name != null ? s.Employee_Name:string.Empty }).Distinct().ToList();
                TempData["lstEmployee"] = (List<ObjSelectList>)list.Select(s => new ObjSelectList { code = s.Code , Name = s.Name }).ToList();
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

                    if (data.EmployeeId != 0)
                    {
                        data.LstOrderDetials = data.LstOrderDetials.Where(s => s.Employee_Id ==  data.EmployeeId).ToList();
                    }

                    if (data.MenuName != "0")
                    {
                        data.LstOrderDetials = data.LstOrderDetials.Where(s => s.Menu_Name.ToUpper().Contains(data.MenuName.ToUpper())).ToList();
                    }


                }                
                TempData.Keep();
            }

            return Json(data.LstOrderDetials, JsonRequestBehavior.AllowGet);
        }

        #region Attendance Report
        public ActionResult AttendanceReport()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AttendanceReport(RptOrderSearchModel data)
        {
            if (ModelState.IsValid)
            {
                data.LstAttendences = RptAttendence.GetBillNotification(RestaurantId);
            }
            return View(data);

        }
        #endregion

    }

    public class ObjSelectList
    {
        public int code { get; set; }
        public string Name { get; set; }
    }
}
