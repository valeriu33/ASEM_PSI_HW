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
            try
            {
                Service service = new Service();

                service.Rate = Convert.ToDecimal(collection["Rate"]);
                service.BeginDate = Convert.ToDateTime(collection["BeginDate"]);
                service.EndDate = Convert.ToDateTime(collection["EndDate"]);
                service.ServiceType = new ServiceType() {Name = collection["ServiceType"]};
                return View();
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
