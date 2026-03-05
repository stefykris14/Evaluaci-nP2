using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S8EvaluacionPractica2P.Controllers
{
    public class DeptEmpsController : Controller
    {
        // GET: DeptEmps
        public ActionResult Index()
        {
            return View();
        }

        // GET: DeptEmps/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeptEmps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeptEmps/Create
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

        // GET: DeptEmps/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeptEmps/Edit/5
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

        // GET: DeptEmps/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeptEmps/Delete/5
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
