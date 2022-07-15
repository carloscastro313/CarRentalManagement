using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "c029105b-76dc-485d-9975-2029cf13b417",
                        UserId = "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f2"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "c029105b-76dc-485d-9975-2029cf13b416",
                        UserId = "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f3"
                    }
                );
        }
    }
}
