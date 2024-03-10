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
        public class Wallets
        {
            //新增屬性可使用快捷鍵prop產生
            public int Id { get; set; }
            public string Name { get; set; }
        }
        // GET: AddItem
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult Create()
        {
            var db = new Database1Entities();
            AddRecordModel recordModel = new AddRecordModel();
            recordModel.walletlist = db.Wallets.ToList();
            return View(recordModel);
        }

        [HttpPost]
        public ActionResult Create(AddRecordModel record, FormCollection obj)
        {
            ViewBag.iore = obj["iore"];
            if (ViewBag.iore == "e")
            {
                record.records.Amt=-record.records.Amt;
            }
            var db = new Database1Entities();
            db.Records.Add(record.records);
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