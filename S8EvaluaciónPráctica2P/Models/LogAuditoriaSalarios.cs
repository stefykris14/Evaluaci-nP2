using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S8EvaluaciónPráctica2P.Models
{
    public class LogAuditoriaSalarios : Controller
    {
        // GET: LogAuditoriaSalarios
        public ActionResult Index()
        {
            return View();
        }

        // GET: LogAuditoriaSalarios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogAuditoriaSalarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogAuditoriaSalarios/Create
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

        // GET: LogAuditoriaSalarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogAuditoriaSalarios/Edit/5
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

        // GET: LogAuditoriaSalarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogAuditoriaSalarios/Delete/5
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
