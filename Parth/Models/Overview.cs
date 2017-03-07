using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Overview
    {
        //PrimaryKey
        public int OverviewId { get; set; }

        //Employee
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        //Department
        public string DepartmenteName { get; set; }
        public int ManagedId { get; set; }

        //Hardware
        public string Model { get; set; }
        public string OS { get; set; }
        public string Company { get; set; }

        //Software
        public string SoftwareName { get; set; }
        public string Version { get; set; }
        public string Vendor { get; set; }

    }
}