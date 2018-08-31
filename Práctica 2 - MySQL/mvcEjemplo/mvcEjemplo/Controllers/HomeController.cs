using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcEjemplo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<String> arrList = new List<string>();
            arrList.Add("Zuñiga&#225;");
            arrList.Add("Zuñiga&#233;");
            arrList.Add("Zuñiga&#237;");
            arrList.Add("Zuñiga");
            arrList.Add("Zuñiga");
            arrList.Add("Zuñiga");
            ViewBag.lstApellidos = arrList;


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
    }
}