using FinancialAssetsWallet.Domain.Model.WalletAggregate.ValueObjects;

namespace FinnacialAssetsWallet.Api.Contracts.Commands
{
    public class InvestorRequest
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string DocumentType { get; set; }

        public Investor ToDomainObject()
        {
            return new Investor(Name, Document, DocumentType);
        }
    }
}