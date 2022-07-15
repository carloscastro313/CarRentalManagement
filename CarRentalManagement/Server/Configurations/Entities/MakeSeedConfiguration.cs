using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    Name = "Toyota",
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now,
                },
                new Make
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    Name = "Fiat",
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now,
                },
                new Make
                {
                    Id = 3,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    Name = "Renault",
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now,
                },
                new Make
                {
                    Id = 4,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    Name = "BMW",
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now,
                }
                );
        }
    }
}
