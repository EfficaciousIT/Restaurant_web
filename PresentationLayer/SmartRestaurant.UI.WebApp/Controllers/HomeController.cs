using SmartRestaurant.Business;
using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartRestaurant.UI.WebApp.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            DashBoardModel dashBoardModel = new DashBoardModel();
            dashBoardModel.OrderDetail = DashBoard.GetOrderNotification(RestaurantId);
            dashBoardModel.TakeAwayDetail = DashBoard.GetTakeAwayNotification(RestaurantId);
            dashBoardModel.DispatchDetail = DashBoard.GetDispatchNotification(RestaurantId);
            dashBoardModel.BillDetail = DashBoard.GetBillNotification(RestaurantId);
            if (objUser.User_Name != null)
            {
                ViewBag.User = objUser.User_Name;
                ViewBag.BillCounter = dashBoardModel.BillDetail.Count();
                ViewBag.TakeAwayCounter = dashBoardModel.TakeAwayDetail.Count();
                ViewBag.DispatchCounter = dashBoardModel.DispatchDetail.Count();
                ViewBag.OrderCounter = dashBoardModel.OrderDetail.Count();
                return View(dashBoardModel);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }

            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ChangeLanguage(string lang)
        {
            SmartRestaurant.UI.WebApp.Helper.CultureHelper.SetLanguage(lang);

            //return Content("sucess");
            return RedirectToAction("Index", "Home");
        }
    }
}