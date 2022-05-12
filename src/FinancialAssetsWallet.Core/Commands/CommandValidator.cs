using FluentValidation;

namespace FinancialAssetsWallet.Core.Commands
{
    public class CommandValidator<T> : AbstractValidator<T> where T : ICommand
    {
        public CommandValidator()
        {
            RuleFor(x => x.Id).NotNull();
        }
    }
}