using System;
using MediatR;

namespace FinancialAssetsWallet.Core.Commands
{
    public interface ICommand
    {
        string Id { get; }
        DateTime Timestamp { get; }
    }

    public interface ICommand<out T> : ICommand, IRequest<T>
    { }
}