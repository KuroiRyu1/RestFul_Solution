using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebRestCall1.Models;
using WebRestCall1.Models.Repositories;

namespace WebRestCall1.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var res = new CategoryApi();
            var data = await res.GetCates();
            ViewBag.Categories = data;
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