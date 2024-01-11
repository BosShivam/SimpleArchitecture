namespace SimpleArchitecture.Api.Endpoints.Order
{
    public class CreateOrderRequest
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }
    }
}
