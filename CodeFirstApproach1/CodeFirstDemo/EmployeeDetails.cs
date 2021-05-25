using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo
{
    public class EmployeeDetails
    {
        [Key]
        public int EmpID { get; set;}
        public string Name{ get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }

    }
}