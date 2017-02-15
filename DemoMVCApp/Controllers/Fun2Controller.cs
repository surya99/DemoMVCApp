using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVCApp.Models;

namespace DemoMVCApp.Controllers
{
    public class Fun2Controller : Controller
    {
        t_UserReg objUserReg = new t_UserReg();
        // GET: Fun2
        public ActionResult Index()
        {
            return View(objUserReg);
        }
        //POST:Login
        public ActionResult Login(t_UserReg objModel)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
                return View(objModel);
        }
        public ActionResult WorkflowDemo()
        {
            return View();
        }
        public ActionResult WorkflowDemoOne()
        {
            return View();
        }
    }
}