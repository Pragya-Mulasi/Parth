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
                new Department { DepartmenteName="CIS" , ManagedId = 1 },
                new Department { DepartmenteName="IMS" , ManagedId = 2 },
            };

            foreach (var temp in department)
            {
                context.Departments.Add(temp);
            }

            context.SaveChanges();

            //Seed Data for Employee
            var employee = new List<Employee>
            {
                new Employee { EmployeeName  = "Ross Geller"  , DepartmentId = 1},
                new Employee { EmployeeName  = "Monica Geller"  , DepartmentId= 2},
                new Employee { EmployeeName  = "Chandler Bing"  , DepartmentId= 1},
                new Employee { EmployeeName  = "Joe T"  , DepartmentId= 1},
                new Employee { EmployeeName  = "Ursala B." , DepartmentId= 2},
                new Employee { EmployeeName  = "Pheebe B."  , DepartmentId= 1},
            };

            foreach (var temp in employee)
            {
                context.Employees.Add(temp);
            }

            context.SaveChanges();

            //Seed Data for Hardware
            var hardware = new List<Hardware>
            {
                new Hardware { Model = "Laptop"  , OS= "Windows 7", Company= "Dell" , EmployeeId = 1 },
                new Hardware { Model = "Desktop"  , OS= "Windows 7", Company= "HP" , EmployeeId = 1},
                new Hardware { Model = "Desktop"  , OS= "Windows 10", Company= "Dell" , EmployeeId = 2},
                new Hardware { Model = "Laptop"  , OS= "Windows 10", Company= "HP" , EmployeeId = 3},
                new Hardware { Model = "Desktop"  , OS= "Windows 7", Company= "HP" , EmployeeId = 4},
                new Hardware { Model = "Desktop"  , OS= "Windows 10", Company= "Dell" , EmployeeId = 5},
                new Hardware { Model = "Laptop"  , OS= "Windows 10", Company= "HP" , EmployeeId = 6 },
            };

            foreach (var temp in hardware)
            {
                context.Hardwares.Add(temp);
            }
            context.SaveChanges();

            //Seed Data for Asset
            var asset = new List<Asset>
            {
                new Asset{ HardwareId = 1 , SoftwareId = 1},
                new Asset{ HardwareId = 1 , SoftwareId = 2 },
                new Asset{ HardwareId = 2 , SoftwareId = 3},
                new Asset{ HardwareId = 3 , SoftwareId = 4},
                new Asset{ HardwareId = 4 , SoftwareId = 1},
                new Asset{ HardwareId = 5 , SoftwareId = 2},
                new Asset{ HardwareId = 6 , SoftwareId = 3},
                new Asset{ HardwareId = 7 , SoftwareId = 4},
            };

            foreach (var temp in asset)
            {
                context.Assets.Add(temp);
            }

            context.SaveChanges();
        }
    }
}