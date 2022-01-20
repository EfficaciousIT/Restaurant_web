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
           return View(Category.GetAll(this.RestaurantId));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CategoryModel category)
        {
            category.Res_Id = this.RestaurantId;
            int result = await Category.Create(category);
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
            CategoryModel = await Category.GetExistingAsync(code, this.RestaurantId);
            return View(CategoryModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(CategoryModel category)
        {
            category.Res_Id = this.RestaurantId;
            int result = await Category.Edit(category);
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
            CategoryModel = await Category.GetExistingAsync(code, this.RestaurantId);
            return View(CategoryModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(CategoryModel category)
        {
            category.Res_Id = this.RestaurantId;
            int result = await Category.Delete(category);
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