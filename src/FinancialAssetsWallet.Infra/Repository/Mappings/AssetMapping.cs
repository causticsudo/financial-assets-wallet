using FinancialAssetsWallet.Domain.Model.WalletAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialAssetsWallet.Infra.Repository.Mappings
{
    public class AssetMapping : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.ToTable("Asset");
            builder.HasKey(x => x.Id);
        }
    }
}