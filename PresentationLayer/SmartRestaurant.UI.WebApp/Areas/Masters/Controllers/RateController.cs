using SmartRestaurant.Business;
using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartRestaurant.UI.WebApp.Controllers
{
    public class RateController : BaseController
    {
        // GET: Masters/Rate
        public ActionResult Index()
        {
            List<RateModel> foodCategoryLst = new List<RateModel>();
            return View(foodCategoryLst);
            // return View(Restaurant.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantModel restaurant)
        {
            return View();
        }
    }
}