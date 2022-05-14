#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialAssetsWallet.Domain.Model.WalletAggregate;

namespace FinancialAssetsWallet.Domain.Repository
{
    internal interface IWalletRepository
    {
        Task<IEnumerable<Wallet>> SearchWalletsAsync();
        Task<Wallet> FindByIdAsync(string? id);
        Task<Wallet> CreateAsync(Wallet asset);
        Task<Wallet> UpdateAsync(Wallet asset);
        Task<Wallet> RemoveAsync(Wallet asset);
    }
}