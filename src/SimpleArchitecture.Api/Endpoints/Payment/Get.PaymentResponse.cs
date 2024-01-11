namespace SimpleArchitecture.Api.Endpoints.Payment
{
    public class GetPaymentResponse
    {
        public Guid PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
