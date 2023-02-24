using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntityConfigurations
{
    public class AppMenuConfiguration : IEntityTypeConfiguration<AppMenu>, IEntityTypeConfiguration<AppMenuRole>
    {
        public void Configure(EntityTypeBuilder<AppMenu> builder)
        {
            builder.ToTable("Menu");
            builder.Navigation(q => q.MenuRoles).AutoInclude();
        }

        public void Configure(EntityTypeBuilder<AppMenuRole> builder)
        {
            builder.ToTable("MenuRoles");
            builder.Navigation(q => q.Role).AutoInclude();
            builder.Navigation(q => q.Menu).AutoInclude();
        }
    }
}
