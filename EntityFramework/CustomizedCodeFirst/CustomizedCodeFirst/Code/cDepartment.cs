using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomizedCodeFirst.Code
{
    public class cDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<Code.cEmployee> cEmployees { get; set; }
    }
}