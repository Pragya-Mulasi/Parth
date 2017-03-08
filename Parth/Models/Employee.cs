using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required][Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        //ForeignKey 
        [Required]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
    }
}