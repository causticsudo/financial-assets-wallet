#nullable enable
using System.Collections.Generic;
using FinnacialAssetsWallet.Domain.Model.WalletAggregate.Entities;

namespace FinnacialAssetsWallet.Domain.Model.WalletAggregate
{
    public class Wallet: Entity
    {
        private const double InitialValue = 0.0;
        public Investor Investor { get; set; }
        public List<Asset>? Assets { get; set; }
        public List<Movimentation>? Movimentations { get; set; }
        public double TotalIncome { get; set; }
        public double TotalInvested { get; set; }

        public Wallet(Investor investor)
        {
            Investor = investor;
            TotalIncome = InitialValue;
            TotalInvested = InitialValue;
        }
    }
}