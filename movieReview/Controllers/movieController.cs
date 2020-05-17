using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace movieReview.Controllers
{
    public class movieController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
    }
}
