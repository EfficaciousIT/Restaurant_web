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
            return View(Restaurant.GetAll(this.RestaurantId));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(RestaurantModel restaurant)
        {
            restaurant.ResId = this.RestaurantId.ToString();
            int result = await Restaurant.Create(restaurant);
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
            restaurantModel = await Restaurant.GetExistingAsync(code, this.RestaurantId);
            return View(restaurantModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(RestaurantModel restaurant)
        {
            restaurant.ResId = this.RestaurantId.ToString();
            int result = await Restaurant.Edit(restaurant);
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
            restaurantModel = await Restaurant.GetExistingAsync(code, this.RestaurantId);
            return View(restaurantModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(RestaurantModel restaurant)
        {
            restaurant.ResId = this.RestaurantId.ToString();
            int result = await Restaurant.Delete(restaurant);
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