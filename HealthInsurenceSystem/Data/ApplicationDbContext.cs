using HealthInsurenceSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsurenceSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Policy> Policy { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Paymentlog> Paymentlog { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Interested> Interested { get; set; }

    }
}
