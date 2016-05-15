using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomizedCodeFirst
{
    public class EmployeeRepository
    {
        public List<Code.cDepartment> GetDepartment()
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            return employeeDBContext.cDepartments.Include("cEmployees").ToList();
        }
    }
}