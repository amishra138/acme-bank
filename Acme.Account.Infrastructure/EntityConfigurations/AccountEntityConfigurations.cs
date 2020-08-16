using Acme.Account.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.Account.Infrastructure.EntityConfigurations
{
    public class AccountEntityConfigurations : IEntityTypeConfiguration<AccountModel>
    {
        public void Configure(EntityTypeBuilder<AccountModel> builder)
        {
            builder.ToTable("Account", AcmeContext.DEFAULT_SCHEMA);

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Type)
                .IsRequired();

            builder
                .Property(x => x.Number)
                .IsRequired();

            builder
                .Property(x => x.MinBalance);

            builder
                .HasMany(x => x.Transactions)
                .WithOne(x => x.Account)
                .HasForeignKey(x => x.AccountId);
        }
    }
}
