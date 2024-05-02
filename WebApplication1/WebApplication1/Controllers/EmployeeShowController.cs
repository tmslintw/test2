using System;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeShowController : Controller
    {
        // GET: EmployeeShow
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(FormCollection obj)
        {
            var db = new Database1Entities();
            ViewEmployee EmployeesModel = new ViewEmployee();

            String test = "Thomas";
            test = obj["employee_name"];
            //int walletid = 1;
            //int.TryParse(obj["walletid"], out walletid);

            EmployeesModel.Employeeslist = db.V_Emplyee_with_Title.Where(m => m.UserName.Contains(test)).OrderBy(m => m.UserID).ToList();
            return View(EmployeesModel);
        }
    }
}