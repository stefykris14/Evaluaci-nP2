using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S8EvaluacionPractica2P.Controllers
{
    public class DeptManagersController : Controller
    {
        // GET: DeptManagers
        public ActionResult Index()
        {
            return View();
        }

        // GET: DeptManagers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeptManagers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeptManagers/Create
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

        // GET: DeptManagers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeptManagers/Edit/5
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

        // GET: DeptManagers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeptManagers/Delete/5
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
