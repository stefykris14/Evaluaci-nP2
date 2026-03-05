using System.Linq;
using System.Web.Mvc;
using S8EvaluacionPractica2P.Models;

namespace S8EvaluacionPractica2P.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Autenticar()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }
    }
}