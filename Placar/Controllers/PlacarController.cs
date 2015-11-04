using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Placar.Controllers
{
    public class PlacarController : Controller
    {
        // GET: Placar
        public ActionResult Futebol()
        {
            return View();
        }
    }
}