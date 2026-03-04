using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaNomina.Models;
using S8EvaluaciónPráctica2P.Models;

namespace S8EvaluaciónPráctica2P.Controllers
{
    public class AccountController : Controller
    {
        private NominaContext db = new NominaContext();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = db.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Session["UserId"] = user.Id;
                Session["Username"] = user.Username;
                Session["Role"] = user.Role;
                return RedirectToAction("Index", "Dashboard");
            }

            ViewBag.Error = "Credenciales incorrectas";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
