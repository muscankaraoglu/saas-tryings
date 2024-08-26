﻿namespace Shared.Features.Messaging.Command
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<TCommand>(TCommand command, CancellationToken cancellation = default) where TCommand : ICommand;
        Task<TResult> DispatchAsync<TCommand, TResult>(TCommand command, CancellationToken cancellation = default) where TCommand : ICommand<TResult>;
    }
}
