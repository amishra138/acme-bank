using Acme.Account.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.Account.Infrastructure.EntityConfigurations
{
    public class AddressEntityConfigurations : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> builder)
        {
            builder.ToTable("Address", AcmeContext.DEFAULT_SCHEMA);

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Type)
                .IsRequired();
        }
    }
}
