using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string employee_Name { get; set; }
        public string job_title { get; set; }
        public DateTime date_started { get; set; }
        public DateTime date_Ended { get; set; }
        public string image { get; set; }
        public byte[] imgUpload { get; set; }
    }

    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext() : base("DefaultConnection") { }
        public DbSet<Employee> Employees { get; set; }
    }
}