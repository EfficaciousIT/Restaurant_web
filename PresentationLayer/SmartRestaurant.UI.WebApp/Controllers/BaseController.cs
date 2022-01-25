using SmartRestaurant.UI.WebApp.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartRestaurant.UI.WebApp.Controllers
{
    public class BaseController : Controller
    {
        public static int RestaurantId { get; set; }
        public static SmartRestaurant.Model.UserModel objUser { get; set; }

        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            if (Session["UserDtl"] != null)
            {
                objUser = Session["UserDtl"] as SmartRestaurant.Model.UserModel;
                RestaurantId = objUser.Res_Id;                
            }
            else
            {
                //return RedirectToAction("Index", "Home");
                //return RedirectToAction("Index", "Home");
            }
            string cultureName = null;
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie != null)
            {
                cultureName = langCookie.Value;
            }
            else
            {
                var userLanguage = Request.UserLanguages;
                var userLang = userLanguage != null ? userLanguage[0] : "";
                if (userLang != "")
                {
                    cultureName = userLang;
                }
                else
                {
                    cultureName = Request.UserLanguages != null && Request.UserLanguages.Length > 0 ? Request.UserLanguages[0] : null; //LanguageMang.GetDefaultLanguage();
                }
            }             

            CultureHelper.SetLanguage(cultureName);
            return base.BeginExecuteCore(callback, state);
        }
    }
}