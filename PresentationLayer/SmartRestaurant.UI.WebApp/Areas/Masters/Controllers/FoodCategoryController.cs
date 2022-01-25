using SmartRestaurant.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartRestaurant.Model;
using System.Threading.Tasks;

namespace SmartRestaurant.UI.WebApp.Controllers
{
    public class FoodCategoryController : BaseController
    {
        // GET: Masters/FoodCategory
        public ActionResult Index()
        {
           return View(Category.GetAll(RestaurantId));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CategoryModel category)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                category.Res_Id = RestaurantId;
                result = await Category.Create(category);
            }
            if (result > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }

        }

        public async Task<ActionResult> Edit(int code)
        {
            CategoryModel CategoryModel = new CategoryModel();
            CategoryModel = await Category.GetExistingAsync(code, RestaurantId);
            return View(CategoryModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(CategoryModel category)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                category.Res_Id = RestaurantId;
                result = await Category.Edit(category);
            }
            if (result > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }

        }

        public async Task<ActionResult> Delete(int code)
        {
            CategoryModel CategoryModel = new CategoryModel();
            CategoryModel = await Category.GetExistingAsync(code, RestaurantId);
            return View(CategoryModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(CategoryModel category)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                category.Res_Id = RestaurantId;
                result = await Category.Delete(category);
            }
            if (result > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }

        }
    }
}