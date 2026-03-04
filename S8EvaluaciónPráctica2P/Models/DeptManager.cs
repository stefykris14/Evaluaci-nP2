using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S8EvaluaciónPráctica2P.Models
{
    public class DeptManager : Controller
    {
        // GET: DeptManager
        public ActionResult Index()
        {
            return View();
        }

        // GET: DeptManager/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeptManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeptManager/Create
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

        // GET: DeptManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeptManager/Edit/5
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

        // GET: DeptManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeptManager/Delete/5
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
