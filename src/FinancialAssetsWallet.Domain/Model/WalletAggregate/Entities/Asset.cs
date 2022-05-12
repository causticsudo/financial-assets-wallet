using System;
using FinancialAssetsWallet.Core.Models;
using FinancialAssetsWallet.Domain.Model.Aggregates.Enumerations;

namespace FinancialAssetsWallet.Domain.Model.WalletAggregate.Entities
{
    public sealed class Asset : Entity
    {
        public AssetType Type { get; set; }
        public string WalletId { get; set; }
        public string Fund { get; set; }
        public string Code { get; set; }
        public double PurchasePrice { get; set; }
        public double? LastSalePrice { get; set; }
        public double? Balance { get;  set; }
        public int Amount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime? LastPurchaseMade { get; set; }
        public DateTime? LastSaleMade { get; set; }

        public Asset(
            string walletId,
            string fund,
            string code,
            AssetType type,
            double purchasePrice,
            int amount)
        {
            WalletId = walletId;
            Fund = fund;
            Code = code;
            Type = type;
            PurchasePrice = purchasePrice;
            PurchaseDate = DateTime.UtcNow;
            Amount = amount;

            GenerateNewGuidIdentity();
        }
    }
}