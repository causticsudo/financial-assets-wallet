using System;
using FinnacialAssetsWallet.Domain.Model.Aggregates.Enumerations;

namespace FinnacialAssetsWallet.Domain.Model.WalletAggregate.Entities
{
    public class Movimentation: Entity
    {
        public DateTime TransactionDate { get; set; }
        public OperationType OperationType { get; set; }
        public string AssetCode { get; set; }
        public int AssetAmount { get; set; }
        public double AssetPrice { get; set; }
        public double TotalTransctionValue { get; set; }
    }
}