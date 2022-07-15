using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    Name = "Duster",
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                },
                new Model
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    Name = "Corolla",
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                },
                new Model
                {
                    Id = 3,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    Name = "Uno",
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                },
                new Model
                {
                    Id = 4,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    Name = "X3",
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                }
                );
        }
    }
}
