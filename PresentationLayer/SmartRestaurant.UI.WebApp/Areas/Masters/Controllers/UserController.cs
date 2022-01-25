using SmartRestaurant.Business;
using SmartRestaurant.Model;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SmartRestaurant.UI.WebApp.Controllers
{
    public class UserController : BaseController
    {
        // GET: Masters/User
        public ActionResult Index()
        {
            return View(SmartRestaurant.Business.User.GetAll(RestaurantId));
        }

        public ActionResult Create()
        {
            UserModel userModel = new UserModel();
            userModel.LstEmployee = Employee.GetAllEmployee(RestaurantId);
            userModel.LstUserType = UserType.GetAll(RestaurantId);
            return View(userModel);
        }

        [HttpPost]
        public async Task<ActionResult> Create(UserModel user)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                user.Res_Id = RestaurantId;
                result = await SmartRestaurant.Business.User.Create(user);
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
            UserModel userModel = new UserModel();
            userModel = await SmartRestaurant.Business.User.GetExistingAsync(code, RestaurantId);
            userModel.LstEmployee = Employee.GetAllEmployee(RestaurantId);
            userModel.LstUserType = UserType.GetAll(RestaurantId);
            return View(userModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(UserModel user)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                user.Res_Id = RestaurantId;
                result = await SmartRestaurant.Business.User.Edit(user);
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
            UserModel userModel = new UserModel();
            userModel = await SmartRestaurant.Business.User.GetExistingAsync(code, RestaurantId);
            userModel.LstEmployee = Employee.GetAllEmployee(RestaurantId);
            userModel.LstUserType = UserType.GetAll(RestaurantId);
            
            return View(userModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(UserModel user)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                user.Res_Id = RestaurantId;
                result = await SmartRestaurant.Business.User.Delete(user);
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