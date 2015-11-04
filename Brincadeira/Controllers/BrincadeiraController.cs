using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Brincadeira.Controllers
{
    public class BrincadeiraController : Controller
    {
        // GET: Brincadeira
        public ActionResult Index()
        {
            return View();
        }
    }
}