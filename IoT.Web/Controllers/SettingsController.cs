using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using IoT.Web.Models;
using MongoDB.Bson;

namespace IoT.Web.Controllers
{
    public class SettingsController : Controller
    {
        private readonly ISettingsRepository _dataAccessProvider = new SettingsRepository();
        public async Task<ActionResult> Index()
        {
            IEnumerable<Settings> settings = await _dataAccessProvider.GetSettingss();
            return View(settings);
        }

        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Settings setting = await _dataAccessProvider.GetSettings(id);
            if (setting == null)
            {
                return HttpNotFound();
            }
            return View(setting);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CoreID,StandardRPM,Allowance,TimeOut,StartAfter")] Settings setting)
        {
            if (ModelState.IsValid)
            {
                await _dataAccessProvider.Add(setting);
                return RedirectToAction("Index");
            }

            return View(setting);
        }

        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Settings setting = await _dataAccessProvider.GetSettings(id);
            if (setting == null)
            {
                return HttpNotFound();
            }
            return View(setting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,CoreID,StandardRPM,Allowance,TimeOut,StartAfter")] Settings setting)
        {
            if (ModelState.IsValid)
            {
                await _dataAccessProvider.Update(setting);
                return RedirectToAction("Index");
            }
            return View(setting);
        }

        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Settings setting = await _dataAccessProvider.GetSettings(id);
            if (setting == null)
            {
                return HttpNotFound();
            }
            return View(setting);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            await _dataAccessProvider.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
