using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using SimpleArchitecture.Core.Contracts;

namespace SimpleArchitecture.Api.Endpoints.Order
{
    public class Get : EndpointBaseSync.WithoutRequest.WithActionResult
    {
        private readonly IOrderRepository _orderRepository;

        public Get(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet("api/[namespace]")]
        public override ActionResult Handle()
        {
            var order = _orderRepository.GetStaticOrder();

            return Ok(new GetOrderResponse
            {
                OrderId = order.OrderId,
                Name = order.Name,
                Notes = order.Notes
            });
        }
    }
}
