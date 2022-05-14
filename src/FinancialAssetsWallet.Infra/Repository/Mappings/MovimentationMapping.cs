using FinancialAssetsWallet.Domain.Model.WalletAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialAssetsWallet.Infra.Repository.Mappings
{
    public class MovimentationMapping
    {
        private const string CurrencyColumnType = "decimal(14,2)";
        private const string DateColumnType = "datetime2(7)";
        private const string IntColumnType = "int";
        private const int IdMaxLength = 36;
        private const int AssetCodeMaxLength = 6;
        private const string EnumColumnType = "tinyint";

        public void Configure(EntityTypeBuilder<Movimentation> builder)
        {
            builder.ToTable("Movimentation");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().IsUnicode(false).HasMaxLength(IdMaxLength);
            builder.Property(x => x.AssetCode).IsRequired().IsUnicode(false).HasMaxLength(AssetCodeMaxLength);
            builder.Property(x => x.AssetPrice).IsRequired(false).HasColumnType(CurrencyColumnType);
            builder.Property(x => x.TransactionAmount).IsRequired(false).HasColumnType(CurrencyColumnType);
            builder.Property(x => x.WalletId).IsRequired().IsUnicode(false).HasMaxLength(IdMaxLength);
            builder.Property(x => x.TransactionDate).IsRequired().HasColumnType(DateColumnType);
            builder.Property(x => x.OperationType).IsRequired().HasColumnType(EnumColumnType);
            builder.Property(x => x.AssetsTotal).IsRequired().HasColumnType(IntColumnType);


            builder.HasOne(x => x.Wallet).WithMany(b => b.Movimentations)
                .HasForeignKey(x => x.WalletId).HasConstraintName("FK_Movimentation_ToWallet");
        }
    }
}