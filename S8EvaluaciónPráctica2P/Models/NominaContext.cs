using SistemaNomina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S8EvaluacionPractica2P.Models
{
    public class NominaContext : DbContext
    {
        public NominaContext() : base("NominaContext") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DeptEmp> DeptEmps { get; set; }
        public DbSet<DeptManager> DeptManagers { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<LogAuditoriaSalarios> LogAuditoria { get; set; }
    }
}
