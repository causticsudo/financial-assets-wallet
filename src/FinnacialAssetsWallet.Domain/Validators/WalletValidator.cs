using FinnacialAssetsWallet.Domain.Model.WalletAggregate;
using FluentValidation;

namespace FinnacialAssetsWallet.Domain.Validators
{
    public class WalletValidator : AbstractValidator<Wallet>
    {
        public WalletValidator()
        {
            RuleFor(wallet => wallet.Investor)
                .NotEmpty()
                .SetValidator(new InvestorValidator());
        }
    }
}