using FinancialAssetsWallet.Domain.Model.WalletAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialAssetsWallet.Infra.Repository.Mappings
{
    public class WalletMapping : IEntityTypeConfiguration<Wallet>
    {
        private const string CurrencyColumnType = "decimal(14,2)";
        private const string DateColumnType = "datetime2(7)";
        private const string EnumColumnType = "tinyint";

        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.ToTable("Wallet");
            builder.HasKey(x => x.Id);

            builder.OwnsOne(x => x.Investor, i =>
            {
                i.Property(t => t.Name).HasColumnName("Name").IsRequired();
                i.Property(t => t.Document).HasColumnName("Document").IsRequired();
                i.Property(t => t.DocumentType).HasColumnName("DocumentType").IsRequired();
            }).ToTable("Investor");

            builder.Property(x => x.Status).IsRequired().HasColumnType(EnumColumnType);
            builder.Property(x => x.TotalIncome).IsRequired().HasColumnType(CurrencyColumnType);
            builder.Property(x => x.TotalInvested).IsRequired().HasColumnType(CurrencyColumnType);
            builder.Property(x => x.CreatedAt).IsRequired(false).HasColumnType(DateColumnType);
        }
    }
}