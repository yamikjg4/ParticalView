using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Partical.Models
{
    public class Employee
    {
        [Display(Name ="Employee Id")]
        public int sid { get; set; }
        [Display(Name = "Employee Name")]
        public string sname { get; set; }
        [Display(Name = "Employee Degree")]
        public string degree { get; set; }
    }
}
