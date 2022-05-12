using FinancialAssetsWallet.Core.Commands;
using FinancialAssetsWallet.Domain.Commands.Validators;
using FinancialAssetsWallet.Domain.Exceptions;
using FinancialAssetsWallet.Domain.Model.Aggregates.Enumerations;
using FinancialAssetsWallet.Domain.Model.WalletAggregate.ValueObjects;
using FluentValidation.Results;

namespace FinancialAssetsWallet.Domain.Commands
{
    public class CreateWallet : Command
    {
        public Investor Investor { get; set; }
        public WalletStatus Status { get; set; }

        public CreateWallet(string aggregateIdentifier, Investor investor) : base(aggregateIdentifier)
        {
            if (investor is null)
            {
                return;
            }

            Investor = investor;
            Status = WalletStatus.Created;
        }

        public new virtual ValidationResult Validate()
        {
            var result = new CreateWalletValidator().Validate(this);

            return (result.IsValid)
                ? result
                : throw new InvalidCommandException();
        }
    }
}