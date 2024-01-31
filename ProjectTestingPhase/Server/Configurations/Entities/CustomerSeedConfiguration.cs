using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTestingPhase.Shared.Domain;
namespace ProjectTestingPhase.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Zi Le",
                    PhoneNo = 97317934,
                    Destination="Tampines Hub",
                },
                new Customer
                {
                    Id = 2,
                    Name = "William",
                    PhoneNo = 79137919,
                    Destination = "Hougang Plaza",
                },
                new Customer
                {
                    Id = 3,
                    Name = "Rowell",
                    PhoneNo = 90204821,
                    Destination = "Safra",
                }
                );
        }
    }
}