using ASP_SignalR.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace ASP_SignalR.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Generated()
        {
            return View();
        }

        public ActionResult NonGenerated()
        {
            return View();
        }

        public ActionResult NonWithGroup()
        {
            return View();
        }
        public ActionResult Report(string name)
        {
            CompanyContext db = new CompanyContext();
            if (name =="")
            {
               Session["error"] = "Please Enter Name";
                return RedirectToAction(nameof(Index));
            }
            else if (db.Chats.Any(e => e.Name == name))
            {
               var client= db.Chats.Where(e => e.Name == name).ToList();
                return View(client);
            }
            else {
                return HttpNotFound();
            }
        }
    }
}