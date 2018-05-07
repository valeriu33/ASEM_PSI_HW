using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankIS.Models;
using BankIS.ViewModels;

namespace BankIS.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View();
        }

        // GET: Service/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Service/Create
        public ActionResult Create()
        {
            var db = new DBcontext();

            var serviceServiceTypeViewModel = new ServiceServiceTypeViewModel();
            serviceServiceTypeViewModel.ServiceTypes = db.ServiceTypes;
            
            
            return View(serviceServiceTypeViewModel);
        }

        // POST: Service/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ViewBag.ServiceSuccess = "The service has been successfuly added";
            var db = new DBcontext();

            var serviceServiceTypeViewModel = new ServiceServiceTypeViewModel();
            serviceServiceTypeViewModel.ServiceTypes = db.ServiceTypes;

            try
            {
                Service service = new Service();
                
                service.Rate = Convert.ToDecimal(Request.Form["Service.Rate"]);
                service.BeginDate = Convert.ToDateTime(Request.Form["BeginDate"]);
                service.EndDate = Convert.ToDateTime(Request.Form["EndDate"]);
                service.ServiceTypeId = Convert.ToInt16(Request.Form["Service.ServiceTypeId"]);
                db.Services.Add(service);
                db.SaveChanges();
                return View(serviceServiceTypeViewModel);
            }
            catch
            {
                return View();
            }
        }

        // GET: Service/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Service/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Service/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Service/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
