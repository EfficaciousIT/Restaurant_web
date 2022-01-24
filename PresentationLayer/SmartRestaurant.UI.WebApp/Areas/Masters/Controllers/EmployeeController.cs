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
    public class EmployeeController : BaseController
    {
        // GET: Masters/Employee
        public ActionResult Index()
        {
            return View(Employee.GetAll(RestaurantId));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(EmployeeModel employee)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                employee.Res_Id = RestaurantId;
                result = await Employee.Create(employee);
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
            
            EmployeeModel EmployeeModel = new EmployeeModel();
            EmployeeModel = await Employee.GetExistingAsync(code, RestaurantId);
            return View(EmployeeModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(EmployeeModel employee)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                employee.Res_Id = RestaurantId;
                result = await Employee.Edit(employee);
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
            EmployeeModel EmployeeModel = new EmployeeModel();
            EmployeeModel = await Employee.GetExistingAsync(code, RestaurantId);
            return View(EmployeeModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(EmployeeModel employee)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                employee.Res_Id = RestaurantId;
                result = await Employee.Delete(employee);
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