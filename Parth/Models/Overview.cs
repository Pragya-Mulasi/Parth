using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Overview
    {
        virtual public Employee employee { get; set; }
        virtual public Hardware hardware { get; set; }
        virtual public Software software { get; set; }
        virtual public Department department { get; set; }
        public int EmployeeId { get; set; }
        public int HardwareId { get; set; }
        public int SoftwareId { get; set; }
        public int DepartmentId { get; set; }
        public string ManagerName { get; set; }
    }
}