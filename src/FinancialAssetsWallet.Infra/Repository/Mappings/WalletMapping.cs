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
        private const int IdMaxLength = 25;

        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.ToTable("Wallet");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().IsUnicode(false).HasMaxLength(IdMaxLength);
            builder.Property(x => x.Status).IsRequired().HasColumnType(EnumColumnType);
            builder.Property(x => x.TotalIncome).IsRequired().HasColumnType(CurrencyColumnType);
            builder.Property(x => x.TotalInvested).IsRequired().HasColumnType(CurrencyColumnType);
            builder.Property(x => x.CreatedAt).IsRequired(false).HasColumnType(DateColumnType);

            builder.OwnsOne(x => x.Investor, i =>
            {
                i.Property(p => p.Name).IsRequired().HasColumnName("Name");
                i.Property(p => p.Document).IsRequired().HasColumnName("Document");
                i.Property(p => p.DocumentType).IsRequired().HasColumnName("DocumentType");
            }).ToTable("Investor");
        }
    }
}