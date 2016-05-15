using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CustomizedCodeFirst
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Code.cDepartment> cDepartments { get; set; }
        public DbSet<Code.cEmployee> cEmployees { get; set; }
    }
}