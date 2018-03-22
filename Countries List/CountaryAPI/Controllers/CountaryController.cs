using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CountaryAPI.Controllers
{
    public class CountaryController : Controller
    {
        // GET: Countary
        public ActionResult Index()
        {
            return View();
        }
    }
}