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
            return View(UserType.GetAll(RestaurantId));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(UserTypeModel userType)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                userType.Res_Id = RestaurantId;
                result = await UserType.Create(userType);
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
            UserTypeModel UserTypeModel = new UserTypeModel();
            UserTypeModel = await UserType.GetExistingAsync(code, RestaurantId);
            return View(UserTypeModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(UserTypeModel userType)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                userType.Res_Id = RestaurantId;
                result = await UserType.Edit(userType);
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
            UserTypeModel UserTypeModel = new UserTypeModel();
            UserTypeModel = await UserType.GetExistingAsync(code, RestaurantId);
            return View(UserTypeModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(UserTypeModel userType)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                userType.Res_Id = RestaurantId;
                result = await UserType.Delete(userType);
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