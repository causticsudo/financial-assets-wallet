using FinnacialAssetsWallet.Domain.Model.Aggregates.Enumerations;
using FinnacialAssetsWallet.Domain.Model.WalletAggregate.Entities;
using FluentValidation;

namespace FinnacialAssetsWallet.Domain.Validators
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
        }

        private void RuleForSaleOperation()
        {
        }
    }
}