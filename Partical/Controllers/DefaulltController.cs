using Microsoft.AspNetCore.Mvc;
using Partical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partical.Controllers
{
    public class DefaulltController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> std=new List<Employee>(){
            new Employee{ sid=1,sname="Yamik",degree="MCA"},
            new Employee{ sid=2,sname="Kavi",degree="Bca"},
            new Employee{ sid=3,sname="Raj",degree="BBA"},
            new Employee{ sid=4,sname="Mahesh",degree="BCOM"},
            new Employee{ sid=5,sname="Rajesh",degree="MCOM"},
            };
            return View(std);
        }
    }
}
