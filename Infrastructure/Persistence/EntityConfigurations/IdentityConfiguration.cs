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
        IEntityTypeConfiguration<ApplicationRole>,
        IEntityTypeConfiguration<ApplicationUserRole>,
        IEntityTypeConfiguration<IdentityUserClaim<string>>,
        IEntityTypeConfiguration<IdentityUserLogin<string>>,
        IEntityTypeConfiguration<IdentityUserToken<string>>,
        IEntityTypeConfiguration<IdentityRoleClaim<string>>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("UserLoginInfo");
            builder.HasIndex(q => q.UserName).IsUnique();
            builder.HasIndex(q => q.Email).IsUnique();
            builder.Navigation(q => q.UserRoles).AutoInclude();
            builder.Navigation(q => q.UserClaims).AutoInclude();
            builder.Navigation(q => q.UserTokens).AutoInclude();
            builder.Navigation(q => q.UserLogins).AutoInclude();
        }

        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.ToTable("Role");
            builder.HasIndex(q => q.Name).IsUnique();
            builder.Navigation(q => q.UserRoles).AutoInclude();
            builder.Navigation(q => q.RoleClaims).AutoInclude();
            builder.Navigation(q => q.MenuRoles).AutoInclude();
        }

        public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            builder.ToTable("UserRoles");
            builder.Navigation(q => q.User).AutoInclude();
            builder.Navigation(q => q.Role).AutoInclude();
            builder.HasOne(q => q.User).WithMany(q => q.UserRoles).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(q => q.Role).WithMany(q => q.UserRoles).OnDelete(DeleteBehavior.NoAction);
        }

        public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
        {
            builder.ToTable("UserClaims");
        }

        public void Configure(EntityTypeBuilder<IdentityUserLogin<string>> builder)
        {
            builder.ToTable("UserLogin");
        }

        public void Configure(EntityTypeBuilder<IdentityUserToken<string>> builder)
        {
            builder.ToTable("UserToken");
        }

        public void Configure(EntityTypeBuilder<IdentityRoleClaim<string>> builder)
        {
            builder.ToTable("RoleClaim");
        }
    }
}
