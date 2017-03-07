using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmenteName { get; set; }
        public int ManagedId { get; set; }
        virtual public Employee employee { get; set; }
    }
}