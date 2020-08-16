using Acme.Account.Core.Models;
using Acme.Account.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Acme.Account.Infrastructure
{
    public class AcmeContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "AcmeDb";

        public AcmeContext(DbContextOptions<AcmeContext> options) : base(options)
        {
        }

        public DbSet<CustomerModel> Customers { get; set; }

        public DbSet<AccountModel> Accounts { get; set; }

        public DbSet<AddressModel> Addresses { get; set; }

        public DbSet<TransactionModel> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CustomerEntityConfigurations());
            builder.ApplyConfiguration(new AccountEntityConfigurations());
            builder.ApplyConfiguration(new AddressEntityConfigurations());
            builder.ApplyConfiguration(new TransactionEntityConfigurations());
        }
    }
}