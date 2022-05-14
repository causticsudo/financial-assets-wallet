using FinancialAssetsWallet.Domain.Model.WalletAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialAssetsWallet.Infra.Repository.Mappings
{
    public class AssetMapping
    {
        private const string CurrencyColumnType = "decimal(14,2)";
        private const string DateColumnType = "datetime2(7)";
        private const string IntColumnType = "int";
        private const int IdMaxLength = 36;
        private const int AssetCodeMaxLength = 6;
        private const int CommonNameMaxLength = 255;
        private const string EnumColumnType = "tinyint";

        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.ToTable("Asset");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().IsUnicode(false).HasMaxLength(IdMaxLength);
            builder.Property(x => x.Code).IsRequired().IsUnicode(false).HasMaxLength(AssetCodeMaxLength);
            builder.Property(x => x.Fund).IsRequired().IsUnicode(false).HasMaxLength(CommonNameMaxLength);
            builder.Property(x => x.Balance).IsRequired(false).HasColumnType(CurrencyColumnType);
            builder.Property(x => x.LastSalePrice).IsRequired(false).HasColumnType(CurrencyColumnType);
            builder.Property(x => x.PurchasePrice).IsRequired(false).HasColumnType(CurrencyColumnType);
            builder.Property(x => x.WalletId).IsRequired().IsUnicode(false).HasMaxLength(IdMaxLength);
            builder.Property(x => x.AssetsTotal).IsRequired().HasColumnType(IntColumnType);
            builder.Property(x => x.PurchaseDate).IsRequired().HasColumnType(DateColumnType);
            builder.Property(x => x.LastSaleMade).IsRequired().HasColumnType(DateColumnType);
            builder.Property(x => x.Type).IsRequired().HasColumnType(EnumColumnType);

            builder.HasOne(x => x.Wallet).WithMany(b => b.Assets)
                .HasForeignKey(x => x.WalletId).HasConstraintName("FK_Asset_ToWallet");
        }
    }
}