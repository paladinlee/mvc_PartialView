using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace mvc_PartialView.Controllers
{
    public class PartialVController : Controller
    {
        // GET: PartialV
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTime()
        {
            Thread.Sleep(2000);

            //字首加底線、字尾加 Partial 是 PartialView 的命名規則
            return PartialView("_GetTimePartial");
        }
    }
}