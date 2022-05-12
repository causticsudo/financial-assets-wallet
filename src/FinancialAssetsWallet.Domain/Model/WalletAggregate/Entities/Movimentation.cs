using System;
using FinancialAssetsWallet.Core.Models;
using FinancialAssetsWallet.Domain.Model.Aggregates.Enumerations;

namespace FinancialAssetsWallet.Domain.Model.WalletAggregate.Entities
{
    public class Movimentation: Entity
    {
        public string WalletId { get; set; }
        public DateTime TransactionDate { get; set; }
        public OperationType OperationType { get; set; }
        public string AssetCode { get; set; }
        public int AssetAmount { get; set; }
        public double AssetPrice { get; set; }
        public double TotalTransctionValue { get; set; }
    }
}