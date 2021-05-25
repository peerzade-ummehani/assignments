using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo
{
    public class EmpDataRepresentation
    {
        public List<EmployeeDetails> GetEmpDetails()
        {
            EmployeeDBContext ebd = new EmployeeDBContext();
            return ebd.lstEmployee.ToList();
 
        }
    }
}