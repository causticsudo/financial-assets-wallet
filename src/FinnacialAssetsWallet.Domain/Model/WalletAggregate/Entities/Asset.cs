using System;
using FinnacialAssetsWallet.Domain.Model.Aggregates.Enumerations;

namespace FinnacialAssetsWallet.Domain.Model.WalletAggregate.Entities
{
    public sealed class Asset : Entity
    {
        public AssetType Type { get; set; }
        public string Fund { get; set; }
        public string Code { get; set; }
        public double PurchasePrice { get; set; }
        public double? LastSalePrice { get; set; }
        public double? Balance { get;  set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime? LastPurchaseMade { get; set; }
        public DateTime? LastSaleMade { get; set; }
        public int Amount { get; set; }

        public Asset(string fund, string code)
        {
            GenerateNewGuidIdentity();
            Fund = fund;
            Code = code;
            PurchaseDate = DateTime.UtcNow;
        }
    }
}