namespace SimpleArchitecture.Api.Bus.Events
{
    public class CreateOrderEvent
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
