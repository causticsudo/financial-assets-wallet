namespace FinnacialAssetsWallet.Api.Contracts.Responses
{
    public class CreateWalletResponse
    {
        public string Id { get; set; }

        public CreateWalletResponse(string walletId)
        {
            Id = walletId;
        }
    }
}