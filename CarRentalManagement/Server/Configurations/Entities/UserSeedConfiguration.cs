using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                    new ApplicationUser
                    {
                        Id = "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f2",
                        Email = "admin@admin.com",
                        NormalizedEmail = "ADMIN@ADMIN.COM",
                        FirstName = "System",
                        LastName = "Admin",
                        UserName = "Admin1",
                        NormalizedUserName = "ADMIN1",
                        PasswordHash = hasher.HashPassword(null, "Admin-Admin1")
                    },
                    new ApplicationUser
                    {
                        Id = "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f3",
                        Email = "user@user.com",
                        NormalizedEmail = "USER@USER.COM",
                        FirstName = "System",
                        LastName = "user",
                        UserName = "USER1",
                        NormalizedUserName = "USER1",
                        PasswordHash = hasher.HashPassword(null, "User-User1")
                    }
                );
        }
    }
}
