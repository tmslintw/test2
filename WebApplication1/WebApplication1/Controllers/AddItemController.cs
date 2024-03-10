using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AddItemController : Controller
    {
        // GET: AddItem
        public ActionResult Index()
        {
            var db = new Database1Entities();
            var model = db.Records.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Record record)
        {
            var db = new Database1Entities();
            db.Records.Add(record);
            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
            
            return RedirectToAction("Index");
            //return View();
        }


    }
}