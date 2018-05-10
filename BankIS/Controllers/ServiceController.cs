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
            return View(new DBcontext().Services);
        }

        // GET: Service/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Service/Create/id
        public ActionResult Create(int id)
        {
            var db = new DBcontext();

            ViewBag.ClientId = id;
            
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
                Service service = new Service
                {
                    Rate = Convert.ToDecimal(Request.Form["Service.Rate"]),
                    BeginDate = Convert.ToDateTime(Request.Form["BeginDate"]),
                    EndDate = Convert.ToDateTime(Request.Form["EndDate"]),
                    ServiceTypeId = Convert.ToInt16(Request.Form["Service.ServiceTypeId"]),
                    ClientId = Convert.ToInt16(Request.Form["Service.ClientID"])
                };


                if (db.Clients.Single(c => c.ID == service.ClientId).Services == null)
                {
                    db.Clients.Single(c => c.ID == service.ClientId).Services = new List<Service>();
                }
                db.Clients.Single(c => c.ID == service.ClientId).Services.Add(service);
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
