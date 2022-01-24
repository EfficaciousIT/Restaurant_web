using SmartRestaurant.Business;
using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SmartRestaurant.UI.WebApp.Controllers
{
    public class MenuController : BaseController
    {
        // GET: Masters/Menu
        public ActionResult Index()
        {
            return View(Menu.GetAll(RestaurantId));
        }

        public ActionResult Create()
        {
            MenuModel menuModel = new MenuModel();
            menuModel.foodCategoryList = Category.GetAll(RestaurantId);
            return View(menuModel);
        }

        [HttpPost]
        public async Task<ActionResult> Create(MenuModel menu)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                menu.Res_id = RestaurantId;
                result = await Menu.Create(menu);
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
            MenuModel menuModel = new MenuModel();            
            menuModel = await Menu.GetExistingAsync(code, RestaurantId);
            menuModel.foodCategoryList = Category.GetAll(RestaurantId);
            return View(menuModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(MenuModel menu)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                menu.Res_id = RestaurantId;
                result = await Menu.Edit(menu);
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
            MenuModel menuModel = new MenuModel();
            menuModel = await Menu.GetExistingAsync(code, RestaurantId);
            menuModel.foodCategoryList = Category.GetAll(RestaurantId);
            return View(menuModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(MenuModel menu)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                menu.Res_id = RestaurantId;
                result = await Menu.Delete(menu);
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