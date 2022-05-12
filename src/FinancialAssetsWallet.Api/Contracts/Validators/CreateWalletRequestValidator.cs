using FinnacialAssetsWallet.Api.Contracts.Commands;
using FluentValidation;

namespace FinnacialAssetsWallet.Api.Contracts.Validators
{
    public class CreateWalletRequestValidator : AbstractValidator<CreateWalletRequest>
    {
        public CreateWalletRequestValidator()
        {
            RuleFor(x => x.Investor).NotEmpty();
        }
    }
}