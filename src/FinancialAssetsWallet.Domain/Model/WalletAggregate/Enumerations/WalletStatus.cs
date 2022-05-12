using System.ComponentModel;

namespace FinancialAssetsWallet.Domain.Model.WalletAggregate.Enumerations
{
    public enum WalletStatus
    {
        [Description("Initial")]
        Initial = 0,

        [Description("Created")]
        Created = 1,

        [Description("Active")]
        Active = 2,

        [Description("Suspended")]
        Suspended = 3
    }
}