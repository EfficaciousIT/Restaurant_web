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
        public int RestaurantId { get; set; }

        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            if (Session["UserDtl"] != null)
            {
                var obj = Session["UserDtl"] as SmartRestaurant.Model.UserModel;
                RestaurantId = obj.Res_Id;                
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