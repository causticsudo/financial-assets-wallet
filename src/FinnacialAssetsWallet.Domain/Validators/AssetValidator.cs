using FinnacialAssetsWallet.Domain.Model.Extensions;
using FinnacialAssetsWallet.Domain.Model.WalletAggregate.Entities;
using FluentValidation;

namespace FinnacialAssetsWallet.Domain.Validators
{
    public class AssetValidator : AbstractValidator<Asset>
    {
        private const short AssetCodeMaxLenght = 5;
        private const short FundNameMaxLenght = 5;

        public AssetValidator()
        {
            RuleFor(asset => asset.Fund)
                .NotEmpty()
                .Matches(RegexExtensions.NameValidationRegex)
                .MaximumLength(FundNameMaxLenght);

            RuleFor(asset => asset.Code)
                .NotEmpty()
                .Matches(RegexExtensions.NameValidationRegex)
                .MaximumLength(AssetCodeMaxLenght);
        }
    }
}