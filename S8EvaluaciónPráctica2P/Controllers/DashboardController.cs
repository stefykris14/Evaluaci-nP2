using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using S8EvaluacionPractica2P.Models;

namespace S8EvaluacionPractica2P.Controllers
{
    public class DashboardController : Controller
    {
        private NominaContext db = new NominaContext();

        public ActionResult Index()
        {
            ViewBag.TotalEmpleados = db.Employees.Count();
            ViewBag.TotalDepartamentos = db.Departments.Count();
            ViewBag.TotalSalarios = db.Salaries.Count();
            ViewBag.TotalTitulos = db.Titles.Count();
            return View();
        }
    }
}