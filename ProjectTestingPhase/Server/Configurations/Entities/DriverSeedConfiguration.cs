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
    public class DriverSeedConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasData(
                new Driver
                {
                    Id = 1,
                    Name="Johny",
                    LicenseNo="8721379139A",
                },
                new Driver
                {
                    Id = 2,
                    Name = "Yong Zhi",
                    LicenseNo = "9371937173B",
                },
                new Driver
                {
                    Id = 3,
                    Name = "Zhen Yong",
                    LicenseNo = "7834914013C",
                }
                );
        }
    }
}