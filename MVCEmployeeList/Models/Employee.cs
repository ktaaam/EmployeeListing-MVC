using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcEmployeeList.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string employee_Name { get; set; }
        public string job_title { get; set; }
        public DateTime date_started { get; set; }
        public DateTime date_Ended { get; set; }
        public byte[] image { get; set; }
    }

    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext() : base("DefaultConnection") { }
        public DbSet<Employee> Employees { get; set; }
    }
}