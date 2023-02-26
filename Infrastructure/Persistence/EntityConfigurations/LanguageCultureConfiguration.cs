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
    public class LanguageCultureConfiguration : IEntityTypeConfiguration<LanguageCulture>
    {
        public void Configure(EntityTypeBuilder<LanguageCulture> builder)
        {
            builder.ToTable("LanguageCulture");
            builder.HasIndex(q => q.LCID).IsUnique();
        }
    }
}
