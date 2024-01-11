using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SimpleArchitecture.Api.Bus.Events;
using SimpleArchitecture.Core.Contracts;
using SW.PrimitiveTypes;

namespace SimpleArchitecture.Api.Endpoints.Order
{
    public class Create : EndpointBaseAsync.WithRequest<CreateOrderRequest>.WithActionResult
    {
        private readonly IPublish _publish;
        private readonly IOrderRepository _orderRepository;

        public Create(IPublish publish, 
                      IOrderRepository orderRepository)
        {
            _publish = publish;
            _orderRepository = orderRepository;
        }

        [HttpPost("api/[namespace]")]
        public override async Task<ActionResult> HandleAsync(CreateOrderRequest request, 
                                                             CancellationToken cancellationToken = default)
        {
            var order = _orderRepository.CreateOrder(new Core.Entities.Order
            {
                Name = request.Name,
                Notes = request.Notes,
                Quantity = request.Quantity
            });

            await _publish.Publish(typeof(CreateOrderEvent).Name, 
                JsonConvert.SerializeObject(new CreateOrderEvent
            {
                    OrderId = order.OrderId,
                    Quantity = order.Quantity,
                    Name = order.Name
            }));
            return Ok("Order Created Successfully!");
        }
    }
}
