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

       Login objUserLogin = new Login();
        

        #region LoginPage
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View(objUserLogin);
        }
        //POST:Login
        [HttpPost]
        public ActionResult Index(Login objModel)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
                return View(objModel);
        }
        #endregion

        #region NewUserRegistration
        [HttpGet]
        public ActionResult UserRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserRegistration(t_UserReg objUser)
        {
            if (ModelState.IsValid)
            {
                return Json("Registration Success",JsonRequestBehavior.AllowGet);
            }
            else
            {
                return View();
            }
        }
        #endregion

        #region WorkFlowDemo
        public ActionResult WorkflowDemo()
        {
            return View();
        }
        public ActionResult WorkflowDemoOne()
        {
            return View();
        }
        #endregion
    }
}