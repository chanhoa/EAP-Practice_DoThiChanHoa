using ManageEmployees.Models.Configuration;
using ManageEmployees.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageEmployees.Models.EF
{
    public class EmployeesDbContext:DbContext
    {
        public EmployeesDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.ApplyConfiguration(new EmployeesConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<Employees> Employees{ get; set; }

    }
}
