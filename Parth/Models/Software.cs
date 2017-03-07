using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Software
    {
        public int SoftwareId { get; set; }
        public string SoftwareName { get; set; }
        public string Version { get; set; }
        public string Vendor { get; set; }

        public virtual ICollection<Hardware> Hardwares { get; set; }
    }
}