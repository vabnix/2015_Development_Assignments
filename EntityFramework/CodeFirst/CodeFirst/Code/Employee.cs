using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Code
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int salary { get; set; }
        public Department Departments { get; set; }
    }
}