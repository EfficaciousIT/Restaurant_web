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
            return View(Menu.GetAll(this.RestaurantId));
        }

        public ActionResult Create()
        {
            MenuModel menuModel = new MenuModel();
            menuModel.foodCategoryList = Category.GetAll(this.RestaurantId);
            return View(menuModel);
        }

        [HttpPost]
        public async Task<ActionResult> Create(MenuModel menu)
        {
            menu.Res_id = this.RestaurantId;
            int result = await Menu.Create(menu);
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
            menuModel = await Menu.GetExistingAsync(code, this.RestaurantId);
            menuModel.foodCategoryList = Category.GetAll(this.RestaurantId);
            return View(menuModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(MenuModel menu)
        {
            menu.Res_id = this.RestaurantId;
            int result = await Menu.Edit(menu);
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
            menuModel = await Menu.GetExistingAsync(code, this.RestaurantId);
            menuModel.foodCategoryList = Category.GetAll(this.RestaurantId);
            return View(menuModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(MenuModel menu)
        {
            menu.Res_id = this.RestaurantId;
            int result = await Menu.Delete(menu);
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