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
    public class PhysicalInventoryDocumentConfiguration : IEntityTypeConfiguration<PhysicalInventoryDocumentHeader>, IEntityTypeConfiguration<PhysicalInventoryDocumentDetail>
    {
        public void Configure(EntityTypeBuilder<PhysicalInventoryDocumentHeader> builder)
        {
            builder.ToTable("PhysicalInventoryDocumentHeader");
            builder.HasIndex(q => q.DocumentNo).IsUnique();
            builder.Navigation(q => q.PhysicalInventoryDetails).AutoInclude(true);
        }

        public void Configure(EntityTypeBuilder<PhysicalInventoryDocumentDetail> builder)
        {
            builder.ToTable("PhysicalInventoryDocumentDetail");
            builder.HasOne(q => q.Product).WithMany(q => q.PhysicalInventoryDetails).OnDelete(DeleteBehavior.NoAction);
            builder.Navigation(q => q.PhysicalInventoryHeader).AutoInclude(true);
            builder.Navigation(q => q.Product).AutoInclude(true);
        }
    }
}
