using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Parth.Models
{
    public class OverviewInitializer : DropCreateDatabaseIfModelChanges<OverviewContext>
    {
        protected override void Seed(OverviewContext context)
        {
            var employee = new List<Employee>
            {
                new Employee { EmployeeName  = "Ross Geller" },
                new Employee { EmployeeName  = "Monica Geller" },
                new Employee { EmployeeName  = "Chandler Bing" },
                new Employee { EmployeeName  = "Joe T" },
                new Employee { EmployeeName  = "Ursala B." },
                new Employee { EmployeeName  = "Pheebe B." },
            };

            foreach (var temp in employee)
            {
                context.Employees.Add(temp);
            }

            context.SaveChanges();

            //Seed Data for Hardware

            var hardware = new List<Hardware>
            {
                new Hardware { Model = "Laptop"  , OS= "Windows 7", Company= "Dell" },
                new Hardware { Model = "Desktop"  , OS= "Windows 7", Company= "HP" },
                new Hardware { Model = "Desktop"  , OS= "Windows 10", Company= "Dell" },
                new Hardware { Model = "Laptop"  , OS= "Windows 10", Company= "HP" },
                new Hardware { Model = "Desktop"  , OS= "Windows 7", Company= "HP" },
                new Hardware { Model = "Desktop"  , OS= "Windows 10", Company= "Dell" },
                new Hardware { Model = "Laptop"  , OS= "Windows 10", Company= "HP" },
            };

            foreach (var temp in hardware)
            {
                context.Hardwares.Add(temp);
            }

            //Seed Data for Software

            var software = new List<Software>
            {
                new Software { SoftwareName ="Visio" , Version= "2012" , Vendor= "Microsoft"},
                new Software { SoftwareName ="Project" , Version= "2013" , Vendor= "Microsoft"},
                new Software { SoftwareName ="Word" , Version= "2016" , Vendor= "Microsoft"},
                new Software { SoftwareName ="Excel" , Version= "2007" , Vendor= "Microsoft"},
            };

            foreach (var temp in software)
            {
                context.Softwares.Add(temp);
            }

            context.SaveChanges();

            //Seed Data for Department

            var department = new List<Department>
            {
                new Department { DepartmenteName="CIS" , ManagedId = 2 },
                new Department { DepartmenteName="IMS" , ManagedId = 1 },
            };

            foreach (var temp in department)
            {
                context.Departments.Add(temp);
            }

            context.SaveChanges();

            //Seed Data for Overview

            var overview = new List<Overview>
            {
                new Overview { EmployeeId = 1 , HardwareId = 1 , SoftwareId= 1, DepartmentId = 1 },
                new Overview { EmployeeId = 1 , HardwareId = 2 , SoftwareId= 2, DepartmentId = 1 },
                new Overview { EmployeeId = 2 , HardwareId = 3 , SoftwareId= 1, DepartmentId = 2 },
                new Overview { EmployeeId = 3 , HardwareId = 4 , SoftwareId= 2, DepartmentId = 2 },
                new Overview { EmployeeId = 4 , HardwareId = 5 , SoftwareId= 3, DepartmentId = 1 },
                new Overview { EmployeeId = 5 , HardwareId = 6 , SoftwareId= 3, DepartmentId = 2 },
                new Overview { EmployeeId = 6 , HardwareId = 7 , SoftwareId= 4, DepartmentId = 1 },
            };

            foreach (var temp in department)
            {
                context.Departments.Add(temp);
            }

            context.SaveChanges();
        }
    }
}