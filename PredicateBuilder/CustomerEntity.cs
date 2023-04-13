using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateBuilder
{
    public class CustomerEntity:IEntityTypeConfiguration<CustomerEntity>
    {
        public int Id { get; set; }

        public string? CustomerName { get; set; }

        public string ?TCNumber { get; set; }

        public string? Gender { get; set; }

        public string ?Email { get; set; }

        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {

            builder.HasKey(p => p.Id);
            builder.Property(p => p.CustomerName).HasColumnName("CUSTOMERNAME");
            builder.Property(p => p.TCNumber).HasColumnName("TCNUMBER");
            builder.Property(p => p.Gender).HasColumnName("GENDER");
            builder.Property(p => p.CustomerName).HasColumnName("CUSTOMERNAME");
            builder.Property(p => p.Email).HasColumnName("EMAIL");
        }
    }
}
