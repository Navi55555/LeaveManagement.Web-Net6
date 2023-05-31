using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "f072ffe7-ace9-4ea6-986c-39a821cbb0d7",
                    UserId = "f01229c5-d122-4b3e-9082-f497c84eb08e",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "4691f418-660f-41ab-a9b6-4bbd24c7c76d",
                    UserId = "2cff23f9-e2a3-4ba7-ab5d-a94829389b1c"
                }
                );
        }
    }
}