using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using System.Web.Mvc;
using SistemaNomina.Models;

namespace SistemaNomina.Controllers
{
    public class AccountController : Controller
    {
        private NominaContext db = new NominaContext();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string usuario, string clave)
        {
            // IMPORTANTE: En producción, usa hash para las contraseñas
            var user = db.Users.FirstOrDefault(u => u.Usuario == usuario && u.Clave == clave);
            if (user != null)
            {
                Session["Usuario"] = user.Usuario;
                Session["EmpNo"] = user.EmpNo;
                return RedirectToAction("Index", "Dashboard");
            }
            ViewBag.Error = "Usuario o contraseña incorrectos.";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
