using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Overview
    {
        public int OverviewId { get; set; }
        public virtual Employee employee { get; set; }
        public virtual Hardware hardware { get; set; }
        public virtual Software software { get; set; }
        public virtual Department department { get; set; }
        public int EmployeeId { get; set; }
        public int HardwareId { get; set; }
        public int SoftwareId { get; set; }
        public int DepartmentId { get; set; }
        public string ManagerName { get; set; }
    }
}