using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required][Display(Name = "Department Name")]
        public string DepartmenteName { get; set; }
        [Required]
        public int ManagedId { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}