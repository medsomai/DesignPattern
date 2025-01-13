namespace BuilderPatternExample
{
    // Classe complexe : Commande
    public class Order
    {
        public string CustomerName { get; set; }
        public string DeliveryAddress { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public string PaymentMethod { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public override string ToString()
        {
            return $"Order for {CustomerName}\n" +
                   $"Delivery Address: {DeliveryAddress}\n" +
                   $"Items: {string.Join(", ", Items)}\n" +
                   $"Payment Method: {PaymentMethod}\n" +
                   $"Delivery Date: {(DeliveryDate.HasValue ? DeliveryDate.Value.ToShortDateString() : "Not specified")}";
        }
    }

    // Builder pour la classe Order
    public class OrderBuilder
    {
        private readonly Order _order = new Order();

        public OrderBuilder SetCustomerName(string name)
        {
            _order.CustomerName = name;
            return this;
        }

        public OrderBuilder SetDeliveryAddress(string address)
        {
            _order.DeliveryAddress = address;
            return this;
        }

        public OrderBuilder AddItem(string item)
        {
            _order.Items.Add(item);
            return this;
        }

        public OrderBuilder SetPaymentMethod(string method)
        {
            _order.PaymentMethod = method;
            return this;
        }

        public OrderBuilder SetDeliveryDate(DateTime date)
        {
            _order.DeliveryDate = date;
            return this;
        }

        public Order Build()
        {
            // Validation ou transformation finale si nécessaire
            if (string.IsNullOrEmpty(_order.CustomerName))
                throw new InvalidOperationException("Customer name is required.");
            if (_order.Items.Count == 0)
                throw new InvalidOperationException("At least one item is required.");
            return _order;
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Création de la commande à l'aide du Builder
            var orderBuilder = new OrderBuilder();
            Order order = orderBuilder
                .SetCustomerName("John Doe")
                .SetDeliveryAddress("123 Elm Street")
                .AddItem("Laptop")
                .AddItem("Mouse")
                .SetPaymentMethod("Credit Card")
                .SetDeliveryDate(DateTime.Now.AddDays(5))
                .Build();

            Console.WriteLine(order);
        }
    }
}
