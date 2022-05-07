using FinnacialAssetsWallet.Domain.Model.Extensions;
using FinnacialAssetsWallet.Domain.Model.WalletAggregate.Entities;
using FluentValidation;

namespace FinnacialAssetsWallet.Domain.Validators
{
    public class InvestorValidator : AbstractValidator<Investor>
    {
        private const short NameMaxLenght = 200;

        public InvestorValidator()
        {
            RuleFor(investor => investor.Name)
                .NotEmpty()
                .Matches(RegexExtensions.NameValidationRegex)
                .MaximumLength(NameMaxLenght);
        }
    }
}