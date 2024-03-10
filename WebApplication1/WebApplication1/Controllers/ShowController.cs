using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using static WebApplication1.Controllers.AddItemController;

namespace WebApplication1.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        public ActionResult Index()
        {
            var db = new Database1Entities();
            var model = db.Wallets.ToList();
            ViewRecordsModel recordsModel = new ViewRecordsModel();
            return View(model);
        }
        public ActionResult Details(FormCollection obj)
        {
            var db = new Database1Entities();
            ViewRecordsModel recordsModel = new ViewRecordsModel();
            
            int walletid = 1 ;
            int.TryParse(obj["walletid"], out walletid); 
            recordsModel.recordslist = db.V_Records_With_Wallet.Where(m => m.WalletId == walletid).OrderByDescending(m => m.Date).ToList();
            return View(recordsModel);
        }
    }
}