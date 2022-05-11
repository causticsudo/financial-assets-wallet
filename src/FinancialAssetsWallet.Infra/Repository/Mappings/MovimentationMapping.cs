using FinancialAssetsWallet.Domain.Model.WalletAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialAssetsWallet.Infra.Repository.Mappings
{
    public class MovimentationMapping : IEntityTypeConfiguration<Movimentation>
    {
        public void Configure(EntityTypeBuilder<Movimentation> builder)
        {
            builder.ToTable("Movimentation");
            builder.HasKey(x => x.Id);
        }
    }
}