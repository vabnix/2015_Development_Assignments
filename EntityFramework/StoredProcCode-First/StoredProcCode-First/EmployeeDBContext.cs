using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StoredProcCode_First
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Code.Employee> Employees { get; set; }
    }
}