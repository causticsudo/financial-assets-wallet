using System;
using System.Collections.Generic;
using System.Linq;
using FinancialAssetsWallet.Core.Models;
using FinancialAssetsWallet.Domain.Model.WalletAggregate.Entities;
using FinancialAssetsWallet.Domain.Model.WalletAggregate.Enumerations;
using FinancialAssetsWallet.Domain.Model.WalletAggregate.ValueObjects;

namespace FinancialAssetsWallet.Domain.Model.WalletAggregate
{
    public sealed class Wallet: Entity
    {
        private const double InitialValue = 0.0;

        public List<Asset> Assets { get; set; }
        public List<Movimentation> Movimentations { get; set; }
        public Investor Investor { get; set; }
        public WalletStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public double TotalIncome { get; set; }
        public double TotalInvested { get; set; }

        public Wallet(Investor investor, DateTime createdAt, WalletStatus status = WalletStatus.Initial)
        {
            Investor = investor;
            TotalIncome = InitialValue;
            TotalInvested = InitialValue;
            CreatedAt = createdAt;
            Status = status;
            Assets = new List<Asset>();
            Movimentations = new List<Movimentation>();
        }

        public bool IsEmpty() => Assets is not null && Assets.Any();

        public bool HasMovimentations() => Movimentations is not null && Movimentations.Any();

        public bool IsActive() => Status is WalletStatus.Active;

        public bool IsSuspended() => Status is WalletStatus.Suspended;

        public bool CanBeSuspended() => true;
    }
}