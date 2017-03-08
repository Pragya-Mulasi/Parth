using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    //Contain data from Hardware and Software
    public class Asset
    {
        [Key]
        public int AssetId { get; set; }

        [Required]
        public int HardwareId { get; set; }
        public virtual Hardware hardware { get; set; }

        [Required]
        public int SoftwareId { get; set; }        
        public virtual Software software { get; set; }

        //ForeignKey
        [Required]
        public int EmployeeId { get; set; }
        public virtual Employee employee { get; set; }

    }
}