using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartRestaurant.UI.WebApp.Controllers
{
    public class MastersHomeController : BaseController
    {
        // GET: Masters/MastersHome
        public ActionResult Index()
        {
            return View();
        }
    }
}