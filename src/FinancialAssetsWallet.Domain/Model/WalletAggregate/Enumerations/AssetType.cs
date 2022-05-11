using System.ComponentModel;

namespace FinancialAssetsWallet.Domain.Model.Aggregates.Enumerations
{
    public enum AssetType
    {
        [Description("StockMarketShares")]
        Stocks = 0,
        [Description("BondsDirectTreasury")]
        DirectTreasury = 1,
        [Description("CertificateBankDeposit")]
        Cdb = 2,
    }
}