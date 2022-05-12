using System.Threading;
using System.Threading.Tasks;
using FinancialAssetsWallet.Domain.Commands;
using FinancialAssetsWallet.Domain.Model.WalletAggregate;
using MediatR;

namespace FinancialAssetsWallet.Domain.CommandsHandlers
{
    public class CreateWalletCommandHandler : IRequestHandler<CreateWallet, Unit>
    {
        public async Task<Unit> Handle(CreateWallet command, CancellationToken cancellationToken)
        {
            command.Validate();

            var aggregate = new Wallet(command.Investor, command.Timestamp, command.Status);

            //_repository.Async(aggregate)

            return await Unit.Task;
        }
    }
}