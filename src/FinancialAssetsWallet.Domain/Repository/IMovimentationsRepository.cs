#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialAssetsWallet.Domain.Model.WalletAggregate.Entities;

namespace FinancialAssetsWallet.Domain.Repository
{
    public interface IMovimentationsRepository
    {
        Task<IEnumerable<Movimentation>> SearchMovimentationsAsync();
        Task<Movimentation> FindByIdAsync(string? id);
        Task<Movimentation> CreateAsync(Movimentation movimentation);
    }
}