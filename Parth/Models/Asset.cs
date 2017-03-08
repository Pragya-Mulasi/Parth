using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    //Contain data from Hardware and Software
    public class Asset
    {
        //PrimaryKey
        public int AssetId { get; set; }

        //Hardware
        public int HardwareId { get; set; }
        public virtual Hardware hardware { get; set; }

        //Software
        public int SoftwareId { get; set; }        
        public virtual Software software { get; set; }

        //ForeignKey
        public int EmployeeId { get; set; }
        public virtual Employee employee { get; set; }

    }
}