using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            var db = new Database1Entities();
            var model = db.V_Records_With_Wallet.OrderByDescending(m => m.Date).ToList();
            return View(model);
        }
    }
}