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

            //限定同網站的Ajax專用
            //也就是即便你知道 Partial View 的叫用網址，也不能在瀏覽器中直接打開
            //Ref:https://www.evernote.com/shard/s307/nl/49104230/a819f692-da81-46f5-80fa-38352ee775a8
            if (Request.IsAjaxRequest())
            {
                //字首加底線、字尾加 Partial 是 PartialView 的命名規則
                return PartialView("_GetTimePartial");
            }
            else
            {
                return Content("Fail");
            }



        }
    }
}