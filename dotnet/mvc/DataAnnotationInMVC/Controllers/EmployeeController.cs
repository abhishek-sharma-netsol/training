using System;
using Microsoft.AspNetCore.Mvc;
using DataAnnotationInMVC.Models;

namespace DataAnnotationInMVC.Controllers
{
    public class EmployeeController : Controller
    { 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
