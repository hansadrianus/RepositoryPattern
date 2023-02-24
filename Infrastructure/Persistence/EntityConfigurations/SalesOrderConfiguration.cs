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
    public class SalesOrderConfiguration : IEntityTypeConfiguration<SalesOrderHeader<int>>, IEntityTypeConfiguration<SalesOrderDetail<int>>
    {
        public void Configure(EntityTypeBuilder<SalesOrderHeader<int>> builder)
        {
            builder.ToTable("SalesOrderHeader");
            builder.HasIndex(q => q.OrderNumber).IsUnique();
            builder.Navigation(q => q.SalesOrderDetails).AutoInclude();
        }

        public void Configure(EntityTypeBuilder<SalesOrderDetail<int>> builder)
        {
            builder.ToTable("SalesOrderDetail");
            builder.HasOne(q => q.Product).WithMany(q => q.SalesOrderDetails).OnDelete(DeleteBehavior.NoAction);
            builder.Navigation(q => q.OrderHeader).AutoInclude();
        }
    }
}
