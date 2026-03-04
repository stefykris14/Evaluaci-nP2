using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S8EvaluaciónPráctica2P.Models
{
    public class NominaContext : Controller
    {
        // GET: NominaContext
        public ActionResult Index()
        {
            return View();
        }

        // GET: NominaContext/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NominaContext/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NominaContext/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NominaContext/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NominaContext/Edit/5
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

        // GET: NominaContext/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NominaContext/Delete/5
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
