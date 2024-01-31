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
    public class CarSeedConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(
                new Car
                {
                    Id = 1,
                    CarType="4-Seater Car",
                    CarStatus="Available",
                    DriverId= null,
                },

                new Car
                {
                    Id = 2,
                    CarType = "4-Seater Car",
                    CarStatus = "Available",
                    DriverId = null,
                },
                new Car
                {
                    Id = 3,
                    CarType = "4-Seater Car",
                    CarStatus = "Available",
                    DriverId = null,
                }
                );
        }
    }
}