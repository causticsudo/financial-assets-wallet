using FluentValidation;

namespace FinancialAssetsWallet.Domain.Commands.Abstractions
{
    public class CommandValidator<T> : AbstractValidator<T> where T : ICommand
    {
        public CommandValidator()
        {
            RuleFor(x => x.Id).NotNull();
        }
    }
}