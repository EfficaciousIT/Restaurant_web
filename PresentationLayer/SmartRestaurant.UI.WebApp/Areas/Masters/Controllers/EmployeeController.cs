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
            return View(Employee.GetAll(this.RestaurantId));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(EmployeeModel employee)
        {
            employee.Res_Id = this.RestaurantId;
            int result = await Employee.Create(employee);
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
            EmployeeModel = await Employee.GetExistingAsync(code, this.RestaurantId);
            return View(EmployeeModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(EmployeeModel employee)
        {
            employee.Res_Id = this.RestaurantId;
            int result = await Employee.Edit(employee);
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
            EmployeeModel = await Employee.GetExistingAsync(code, this.RestaurantId);
            return View(EmployeeModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(EmployeeModel employee)
        {
            employee.Res_Id = this.RestaurantId;
            int result = await Employee.Delete(employee);
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