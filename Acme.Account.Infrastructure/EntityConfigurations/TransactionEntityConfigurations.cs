using Acme.Account.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.Account.Infrastructure.EntityConfigurations
{
    class TransactionEntityConfigurations : IEntityTypeConfiguration<TransactionModel>
    {
        public void Configure(EntityTypeBuilder<TransactionModel> builder)
        {
            builder.ToTable("Transaction", AcmeContext.DEFAULT_SCHEMA);

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Type)
                .IsRequired();

            builder
                .Property(x => x.Amount)
                .IsRequired();

            builder
                .Property(x => x.Remarks);
        }
    }
}
