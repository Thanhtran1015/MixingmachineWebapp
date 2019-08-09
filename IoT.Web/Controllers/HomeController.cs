using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using IoT.Web.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace IoT.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRPMDisplayDataRepository _dataAccessProvider = new RPMDisplayDataRepository();
        public async Task<ActionResult> Index()
        {
         //var model =  await _dataAccessProvider.GetRPMDisplayDatas();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public async Task<ActionResult> Chart()
        {
            ViewBag.Message = "Chart";
            return View();
        }
        public ActionResult ListMachine()
        {
            ViewBag.Message = "List Machines";

            return View();
        }
    }
}