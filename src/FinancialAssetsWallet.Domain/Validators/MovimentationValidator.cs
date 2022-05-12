using FinancialAssetsWallet.Domain.Model.Aggregates.Enumerations;
using FinancialAssetsWallet.Domain.Model.Extensions;
using FinancialAssetsWallet.Domain.Model.WalletAggregate.Entities;
using FluentValidation;

namespace FinancialAssetsWallet.Domain.Validators
{
    public class MovimentationValidator : AbstractValidator<Movimentation>
    {
        public MovimentationValidator()
        {
            When(movimentation => movimentation.OperationType == OperationType.Purchase, RuleForPurchaseOperation);
            When(movimentation => movimentation.OperationType == OperationType.Sale, RuleForSaleOperation);
        }

        private void RuleForPurchaseOperation()
        {
            CommonOperationRules();
        }

        private void RuleForSaleOperation()
        {
            CommonOperationRules();
        }

        private void CommonOperationRules()
        {
            RuleFor(movimentation => movimentation.AssetPrice)
                .GreaterThan(0.0);

            RuleFor(movimentation => movimentation.AssetCode)
                .NotEmpty()
                .Matches(RegexExtensions.NameValidationRegex);

            RuleFor(movimentation => movimentation.AssetAmount)
                .GreaterThan(0);

            RuleFor(movimentation => movimentation.TransactionDate)
                .NotEmpty();
        }
    }
}