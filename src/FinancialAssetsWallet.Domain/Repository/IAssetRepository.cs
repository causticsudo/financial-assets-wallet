#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialAssetsWallet.Domain.Model.WalletAggregate.Entities;

namespace FinancialAssetsWallet.Domain.Repository
{
    public interface IAssetRepository
    {
        Task<IEnumerable<Asset>> SearchAssetsAsync();
        Task<Asset> FindByIdAsync(string? id);
        Task<Asset> CreateAsync(Asset asset);
        Task<Asset> UpdateAsync(Asset asset);
        Task<Asset> RemoveAsync(Asset asset);
    }
}