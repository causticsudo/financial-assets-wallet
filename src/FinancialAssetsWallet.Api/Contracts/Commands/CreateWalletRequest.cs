using FinancialAssetsWallet.Domain.Commands;
using FinancialAssetsWallet.Domain.Exceptions;
using FinancialAssetsWallet.Domain.Model;
using FinnacialAssetsWallet.Api.Contracts.Validators;

namespace FinnacialAssetsWallet.Api.Contracts.Commands
{
    public class CreateWalletRequest
    {
        public InvestorRequest Investor { get; set; }

        public void Validate()
        {
            var result = new CreateWalletRequestValidator().Validate(this);

            if (!result.IsValid)
            {
                throw new InvalidRequestException();
            }
        }

        public CreateWallet FromRequestToCommand()
        {
            var investor = Investor.ToDomainObject();
            var aggregateIdentifier = IdentityGenerator.NewGuidId();

            return new CreateWallet(aggregateIdentifier, investor);
        }
    }
}