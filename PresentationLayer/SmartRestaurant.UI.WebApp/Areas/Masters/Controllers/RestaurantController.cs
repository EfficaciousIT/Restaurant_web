using SmartRestaurant.Business;
using SmartRestaurant.Model;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SmartRestaurant.UI.WebApp.Controllers
{
    public class RestaurantController : BaseController
    {
        // GET: Masters/Restaurant
        public ActionResult Index()
        {
            return View(Restaurant.GetAll(RestaurantId));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(RestaurantModel restaurant)
        {

            int result = 0;
            if (ModelState.IsValid)
            {
                restaurant.ResId = RestaurantId.ToString();
                result = await Restaurant.Create(restaurant);
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
            RestaurantModel restaurantModel = new RestaurantModel();
            restaurantModel = await Restaurant.GetExistingAsync(code, RestaurantId);
            return View(restaurantModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(RestaurantModel restaurant)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                restaurant.ResId = RestaurantId.ToString();
                result = await Restaurant.Edit(restaurant);
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
            RestaurantModel restaurantModel = new RestaurantModel();
            restaurantModel = await Restaurant.GetExistingAsync(code, RestaurantId);
            return View(restaurantModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(RestaurantModel restaurant)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                restaurant.ResId = RestaurantId.ToString();
                result = await Restaurant.Delete(restaurant);
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