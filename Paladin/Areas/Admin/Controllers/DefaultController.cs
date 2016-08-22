using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ar.Present.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
     
        public ActionResult Index()
        {
            return View();
        }
    }
}