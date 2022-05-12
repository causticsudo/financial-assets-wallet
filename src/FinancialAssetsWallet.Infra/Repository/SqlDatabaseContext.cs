using FinancialAssetsWallet.Domain.Model.WalletAggregate;
using FinancialAssetsWallet.Domain.Model.WalletAggregate.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancialAssetsWallet.Infra.Repository
{
    public class SqlDatabaseContext : DbContext
    {
        public virtual DbSet<Wallet> Wallet { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<Movimentation> Movimentation { get; set; }

        public SqlDatabaseContext(DbContextOptions<SqlDatabaseContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.
                ApplyConfigurationsFromAssembly(typeof(SqlDatabaseContext).Assembly);
        }
    }
}