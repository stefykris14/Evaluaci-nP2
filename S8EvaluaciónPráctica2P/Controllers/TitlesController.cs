using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S8EvaluaciónPráctica2P.Controllers
{
    public class TitlesController : Controller
    {
        // GET: Titles
        public ActionResult Index()
        {
            return View();
        }

        // GET: Titles/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Titles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Titles/Create
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

        // GET: Titles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Titles/Edit/5
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

        // GET: Titles/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Titles/Delete/5
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
