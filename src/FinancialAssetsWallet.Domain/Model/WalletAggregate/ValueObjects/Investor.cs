using System.Collections.Generic;

namespace FinancialAssetsWallet.Domain.Model.WalletAggregate.ValueObjects
{
    public class Investor : ValueObject
    {
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string DocumentType { get; private set; }

        public Investor(string name, string document, string documentType)
        {
            Name = name;
            Document = document;
            DocumentType = documentType;
        }

        public Investor()
        { }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Document;
            yield return DocumentType;
        }
    }
}