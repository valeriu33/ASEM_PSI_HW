 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 using System.Web.Services.Description;
 using BankIS.Models;
 using Service = BankIS.Models.Service;

namespace BankIS.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            DBcontext db = new DBcontext();
            return View(db.Clients.ToList());
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ViewBag.messageSuccess = "The Client was successufuly registered";
            var db = new DBcontext();
            Client newClient = new Client();
            try
            {
                newClient.FirstName = Request.Form["FirstName"];
                newClient.LastName = Request.Form["LastName"];
                newClient.BirthDate = Convert.ToDateTime(Request.Form["BirthDate"]);
                newClient.Gender = Convert.ToChar(Request.Form["Gender"]);
                newClient.PersonalId = Convert.ToDecimal(Request.Form["PersonalId"]);

                db.Clients.Add(newClient);
                db.SaveChanges();
                // TODO: Add insert logic here

                return View();
            }
            catch
            {
                return Content("An error occured");
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
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

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var db = new DBcontext();
                Client clientToRm = db.Clients.First(c => c.ID == id);
                db.Clients.Remove(clientToRm);

                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index"); ;
            }
        }
    }
}
