using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class Hardware
    {
        [Key]
        public int HardwareId { get; set; }
        [Required]
        public string Model { get; set; }
        [Required][Display(Name = "Operating System")]
        public string OS { get; set; }
        [Required]
        public string Company { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
    }
}