using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Hardware
    {
        public int HardwareId { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public string Company { get; set; }

        public virtual Employee employee { get; set; }
        public virtual ICollection<Software> Softwares { get; set; }
    }
}