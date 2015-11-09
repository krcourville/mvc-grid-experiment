using MvcTypescript.MvcWebClient.Models;
using MvcTypescript.MvcWebClient.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTypescript.MvcWebClient.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Create()
        {

            ViewBag.Title = "Add Employee";
            ViewBag.Instructions = "Complete the following fields and click Submit.  Required fields are marked with asterisk (*).";
            ViewBag.ReturnUrl = Url.Action("Index", "Home");
            ViewBag.ReturnText = "Home";

            var employeeViewModel = new EmployeeUpsertViewModel();

            return View("_StandardForm", employeeViewModel);
        }
    }
}