namespace FinnacialAssetsWallet.Domain.Model.WalletAggregate.Entities
{
    public class Investor : Entity
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string DocumentType { get; set; }

        public Investor(string name, string document, string documentType)
        {
            Name = name;
            Document = document;
            DocumentType = documentType;
        }
    }
}