using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Software
    {
        [Key]
        public int SoftwareId { get; set; }
        [Required]
        public string SoftwareName { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public string Vendor { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
    }
}