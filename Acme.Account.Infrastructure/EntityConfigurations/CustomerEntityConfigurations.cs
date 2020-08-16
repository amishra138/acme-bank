using Acme.Account.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.Account.Infrastructure.EntityConfigurations
{
    public class CustomerEntityConfigurations : IEntityTypeConfiguration<CustomerModel>
    {
        public void Configure(EntityTypeBuilder<CustomerModel> builder)
        {
            builder.ToTable("Customer", AcmeContext.DEFAULT_SCHEMA);

            builder.HasKey(x => x.Id);
            builder
                .Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(20);
            builder
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(x => x.Mobile)
                .IsRequired()
                .HasMaxLength(20);

            builder
               .Property(x => x.Email)
               .IsRequired()
               .HasMaxLength(20);

            builder
               .HasMany(x => x.Addresses)
               .WithOne(x => x.Customer)
               .HasForeignKey(x => x.CustomerId);

            builder
               .HasMany(x => x.Accounts)
               .WithOne(x => x.Customer)
               .HasForeignKey(x => x.CustomerId);

            builder
               .Property(x => x.CreatedBy)
               .IsRequired();

            builder
              .Property(x => x.CreatedByUserName)
              .IsRequired();

            builder
              .Property(x => x.CreatedOn)
              .IsRequired();
        }
    }
}
