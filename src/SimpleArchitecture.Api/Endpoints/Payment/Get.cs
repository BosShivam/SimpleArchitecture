using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace SimpleArchitecture.Api.Endpoints.Payment
{
    public class Get : EndpointBaseSync.WithRequest<GetPaymentRequest>.WithActionResult<GetPaymentResponse>
    {
        [HttpGet("api/[namespace]/{PaymentId}")]
        public override ActionResult<GetPaymentResponse> Handle([FromRoute] GetPaymentRequest request)
        {
            return Ok(new GetPaymentResponse
            {
                PaymentId = request.PaymentId,
                Amount = 299,
                Currency = "INR"
            });
        }
    }
}
