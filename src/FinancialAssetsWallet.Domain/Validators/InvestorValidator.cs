using FinancialAssetsWallet.Domain.Model.Extensions;
using FinancialAssetsWallet.Domain.Model.WalletAggregate.ValueObjects;
using FluentValidation;

namespace FinancialAssetsWallet.Domain.Validators
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