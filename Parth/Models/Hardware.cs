using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Hardware
    {
        //PrimaryKey
        public int HardwareId { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public string Company { get; set; }

        //ForeignKey
        public int EmployeeId { get; set; }
        public virtual Employee employee { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
    }
}