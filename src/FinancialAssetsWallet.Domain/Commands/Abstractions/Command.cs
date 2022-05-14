using System;
using FinancialAssetsWallet.Core.Commands;
using FluentValidation.Results;
using MediatR;

namespace FinancialAssetsWallet.Domain.Commands.Abstractions
{
    public abstract class Command : ICommand<Unit>
    {
        public virtual string Id { get; }
        public DateTime Timestamp { get; }
        public virtual ValidationResult ValidationResult { get; set; }

        protected Command(string aggregateIdentifier)
        {
            Id = aggregateIdentifier;
            Timestamp = DateTime.UtcNow;
        }

        public virtual bool IsValid()
        {
            var result = Validate();

            ValidationResult = new ValidationResult(result.Errors);

            return result.IsValid;
        }

        public virtual ValidationResult Validate()
        {
            return new CommandValidator<Command>().Validate(this);
        }
    }

    public abstract class Command<T> : Command, ICommand<T>
    {
        protected Command(string aggregateIdentifier) : base(aggregateIdentifier)
        { }
    }
}