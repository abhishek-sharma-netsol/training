using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CodeToDbApproach.Models;

namespace CodeToDbApproach.Controllers
{
    public class Employee: Controller {
        public IActionResult Index(){
            return View();
        }        
    }
}