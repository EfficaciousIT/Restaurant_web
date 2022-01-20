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
    public class UserTypeController : BaseController
    {
        // GET: Masters/UserType
        public ActionResult Index()
        {
            return View(UserType.GetAll(this.RestaurantId));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(UserTypeModel userType)
        {
            userType.Res_Id = this.RestaurantId;
            int result = await UserType.Create(userType);
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
            UserTypeModel UserTypeModel = new UserTypeModel();
            UserTypeModel = await UserType.GetExistingAsync(code, this.RestaurantId);
            return View(UserTypeModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(UserTypeModel userType)
        {
            userType.Res_Id = this.RestaurantId;
            int result = await UserType.Edit(userType);
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
            UserTypeModel UserTypeModel = new UserTypeModel();
            UserTypeModel = await UserType.GetExistingAsync(code, this.RestaurantId);
            return View(UserTypeModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(UserTypeModel userType)
        {
            userType.Res_Id = this.RestaurantId;
            int result = await UserType.Delete(userType);
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