using System;
using MediatR;

namespace FinancialAssetsWallet.Domain.Commands.Abstractions
{
    public interface ICommand
    {
        string Id { get; }
        DateTime Timestamp { get; }
    }

    public interface ICommand<out T> : ICommand, IRequest<T>
    { }
}