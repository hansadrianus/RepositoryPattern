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
    public class PaymentTypeConfiguration : IEntityTypeConfiguration<PaymentType>
    {
        public void Configure(EntityTypeBuilder<PaymentType> builder)
        {
            builder.ToTable("PaymentType");
        }
    }
}
