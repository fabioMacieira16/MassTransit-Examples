using MassTransit;
using Microsoft.Extensions.Logging;
using Shared.Model;
using System;
using System.Threading.Tasks;

namespace OrderPublisher
{
    public class TicketConsumer : IConsumer<Ticket>
    {
        private readonly ILogger _logger;
        public TicketConsumer(ILogger<TicketConsumer> logger)
        {
            this._logger = logger;
        }

        public async Task Consume(ConsumeContext<Ticket> context)
        {
            await Console.Out.WriteAsync(context.Message.UserName);

            _logger.LogInformation($"NEW MESSAGE RECEIVED : " + 
                $" { context.Message.UserName } { context.Message.Location }" );
        }
    }
}