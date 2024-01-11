using SimpleArchitecture.Api.Bus.Events;
using SW.PrimitiveTypes;
using System;

namespace SimpleArchitecture.Api.Bus.Consumers
{
    public class CreateOrderConsumer : IConsume<CreateOrderEvent>
    {
        private readonly ILogger<CreateOrderConsumer> _logger;

        public CreateOrderConsumer(ILogger<CreateOrderConsumer> logger)
        {
            _logger = logger;
        }

        public async Task Process(CreateOrderEvent message)
        {
            //Generate Delay from 1 - 4 seconds
            await Task.Delay(new Random().Next(1, 4) * 1000);

            _logger.LogInformation("\n--\nYour Order Number is " + message.OrderId);
        }
    }
}
