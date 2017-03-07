using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Employee
    {
        //PrimaryKey
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        //ForeignKey
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<Hardware> Hardwares { get; set; }
    }
}