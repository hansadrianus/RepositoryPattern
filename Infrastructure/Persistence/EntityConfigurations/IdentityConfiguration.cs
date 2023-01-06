using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Persistence.EntityConfigurations
{
    public class IdentityConfiguration :
        IEntityTypeConfiguration<ApplicationUser>,
        IEntityTypeConfiguration<IdentityRole>,
        IEntityTypeConfiguration<IdentityUserClaim<string>>,
        IEntityTypeConfiguration<IdentityUserRole<string>>,
        IEntityTypeConfiguration<IdentityUserLogin<string>>,
        IEntityTypeConfiguration<IdentityRoleClaim<string>>,
        IEntityTypeConfiguration<IdentityUserToken<string>>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("UserLoginInfo");
            builder.HasIndex(q => q.UserName).IsUnique();
            builder.HasIndex(q => q.Email).IsUnique();
        }

        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.ToTable("Role");
            builder.HasIndex(q => q.Name).IsUnique();
        }

        public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
        {
            builder.ToTable("UserClaims");
        }

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.ToTable("UserRoles");
        }

        public void Configure(EntityTypeBuilder<IdentityUserLogin<string>> builder)
        {
            builder.ToTable("UserLogin");
        }

        public void Configure(EntityTypeBuilder<IdentityRoleClaim<string>> builder)
        {
            builder.ToTable("RoleClaim");
        }

        public void Configure(EntityTypeBuilder<IdentityUserToken<string>> builder)
        {
            builder.ToTable("UserToken");
        }
    }
}
