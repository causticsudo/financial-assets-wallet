using FinancialAssetsWallet.Core.Commands;
using FinancialAssetsWallet.Domain.Model.Aggregates.Enumerations;
using FinancialAssetsWallet.Domain.Model.WalletAggregate.Enumerations;
using FinancialAssetsWallet.Domain.Validators;
using FluentValidation;

namespace FinancialAssetsWallet.Domain.Commands.Validators
{
    public class CreateWalletValidator : Abstractions.CommandValidator<CreateWallet>
    {
        public CreateWalletValidator()
        {
            RuleFor(x => x.Investor).NotNull().
                SetValidator(new InvestorValidator())
                .WithMessage("Investor is not valid");

            RuleFor(x => x.Status).NotNull()
                .Must(x => x == WalletStatus.Created)
                .WithMessage("Command status is not valid");
        }
    }
}