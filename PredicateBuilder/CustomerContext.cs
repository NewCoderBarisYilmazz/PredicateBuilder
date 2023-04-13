using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateBuilder
{
    public  class CustomerContext:DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-UUKUT9CD\SQLEXPRESS;Initial Catalog=CUSTOMERS;Integrated Security=True;Encrypt=False");
            
        }

        public DbSet<CustomerEntity> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerEntity>().ToTable("CUSTOMERS");
            modelBuilder.ApplyConfiguration<CustomerEntity>(new CustomerEntity());
        }
    }
}
