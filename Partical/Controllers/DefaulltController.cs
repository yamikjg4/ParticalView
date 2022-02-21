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
            List<Student> std=new List<Student>(){
            new Student{ sid=1,sname="Yamik",degree="MCA"},
            new Student{ sid=2,sname="Kavi",degree="Bca"},
            new Student{ sid=3,sname="Raj",degree="BBA"},
            new Student{ sid=4,sname="Mahesh",degree="BCOM"},
            new Student{ sid=5,sname="Rajesh",degree="MCOM"},
            };
            return View(std);
        }
    }
}
