using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst
{
    public class EmployeeRepository
    {
        public List<Code.Department> GetDepartments()
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            return employeeDBContext.Departments.Include("Employees").ToList();
        }
    }
}