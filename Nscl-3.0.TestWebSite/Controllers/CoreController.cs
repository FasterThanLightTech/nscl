using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nscl_3._0.TestWebSite.Controllers
{
    public class CoreController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CwoTestExtraOtherwise()
        {
            return View();
        }

        public ActionResult CwoTestFirstWhen()
        {
            return View();
        }
        public ActionResult CwoTestMissingOtherwise()
        {
            return View();
        }
        public ActionResult CwoTestMissingWhen()
        {
            return View();
        }
        public ActionResult CwoTestOtherwise()
        {
            return View();
        }
        public ActionResult CwoTestSecondWhen()
        {
            return View();
        }
        public ActionResult ForEachTest()
        {

            List<string> names = new List<string>();
            names.Add("a");
            names.Add("b");
            names.Add("c");
            ViewData["items"] = names;
            return View();
        }
        public ActionResult ForEachTestMissingItems()
        {
            return View();
        }
        public ActionResult IfTestConditionMissing()
        {
            return View();
        }
        public ActionResult IfTestReturnsFalse()
        {
            return View();
        }
        public ActionResult IfTestReturnsTrue()
        {
            return View();
        }
        public ActionResult ScopeTest()
        {
            ViewData["msg"] = "From view data.";
            return View();
        }



    }
}
