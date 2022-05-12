using System.Threading.Tasks;
using FinnacialAssetsWallet.Api.Contracts.Commands;
using FinnacialAssetsWallet.Api.Contracts.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FinnacialAssetsWallet.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/wallets")]
    public class WalletController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WalletController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateWalletRequest request)
        {
            request.Validate();

            var command = request.FromRequestToCommand();

            await _mediator.Send(command);

            return Accepted($"v1/wallets/{command.Id}", new CreateWalletResponse(command.Id));
        }
    }
}