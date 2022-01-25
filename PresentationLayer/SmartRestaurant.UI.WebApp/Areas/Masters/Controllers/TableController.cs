using SmartRestaurant.Business;
using SmartRestaurant.Model;
using SmartRestaurant.UI.WebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SmartRestaurant.UI.WebApp.Controllers
{
    public class TableController : BaseController
    {
        // GET: Masters/Table
        public ActionResult Index()
        {
            return View(Table.GetAll(RestaurantId));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(TableModel table)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                table.Res_Id = RestaurantId;
                result = await Table.Create(table);
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
            TableModel TableModel = new TableModel();
            TableModel = await Table.GetExistingAsync(code, RestaurantId);
            return View(TableModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(TableModel table)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                table.Res_Id = RestaurantId;
                result = await Table.Edit(table);
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
            TableModel TableModel = new TableModel();
            TableModel = await Table.GetExistingAsync(code, RestaurantId);
            return View(TableModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(TableModel table)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                table.Res_Id = RestaurantId;
                result = await Table.Delete(table);
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