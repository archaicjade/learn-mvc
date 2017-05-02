using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary2;

namespace mvc.learn.com.Controllers
{
    public class HomeController : Controller
    {

        private ILog _log;
        private IEnumerable<ILog> _loglist;

        public HomeController(ILog logger, IEnumerable<ILog> logList)
        {
            this._log = logger;
            this._loglist = logList;
        }

        public ActionResult Index()
        {
            ViewBag.LogTypeName = this._log.GetType().Name;
            ViewBag.Message = this._log.SaveLog("hello autofac mvc");

            ViewBag.LogTypeNames = _loglist.Select(x => x.GetType().Name).Aggregate((x, y) => x + "," + y);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Avalon()
        {
            ViewBag.Message = "let's learn avalon.";

            return View();
        }
    }
}