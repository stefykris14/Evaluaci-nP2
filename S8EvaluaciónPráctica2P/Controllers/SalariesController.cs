using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S8EvaluaciónPráctica2P.Controllers
{
    public class SalariesController : Controller
    {
        // GET: Salaries
        public ActionResult Index()
        {
            return View();
        }

        // GET: Salaries/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Salaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salaries/Create
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

        // GET: Salaries/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Salaries/Edit/5
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

        // GET: Salaries/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Salaries/Delete/5
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
