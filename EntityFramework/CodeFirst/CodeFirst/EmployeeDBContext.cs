using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirst
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Code.Department> Departments { get; set; }
        public DbSet<Code.Employee> Employees { get; set; }
    }
}