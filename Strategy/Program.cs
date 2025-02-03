namespace StrategyPatternExample
{
    public interface IShippingStrategy
    {
        decimal CalculateShippingCost(decimal orderAmount);
    }


    public class StandardShipping : IShippingStrategy
    {
        public decimal CalculateShippingCost(decimal orderAmount)
        {
            return 5.0m; // Tarif fixe de 5€
        }
    }

    public class ExpressShipping : IShippingStrategy
    {
        public decimal CalculateShippingCost(decimal orderAmount)
        {
            return 10.0m; // Tarif fixe de 10€
        }
    }

    public class InStorePickup : IShippingStrategy
    {
        public decimal CalculateShippingCost(decimal orderAmount)
        {
            return 0.0m; // Gratuit pour le retrait en magasin
        }
    }

    public class Order
    {
        private IShippingStrategy? _shippingStrategy;

        public void SetShippingStrategy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public void ProcessOrder(decimal orderAmount)
        {
            if (_shippingStrategy == null)
            {
                Console.WriteLine("Aucune méthode de livraison sélectionnée !");
                return;
            }

            decimal shippingCost = _shippingStrategy.CalculateShippingCost(orderAmount);
            Console.WriteLine($"Frais de livraison : {shippingCost}€");
        }
    }
    class Program
    {
        static void Main()
        {
            var order = new Order();

            // 🚚 Livraison Standard
            order.SetShippingStrategy(new StandardShipping());
            Console.WriteLine("Commande avec Livraison Standard :");
            order.ProcessOrder(50);

            // 🚀 Livraison Express
            order.SetShippingStrategy(new ExpressShipping());
            Console.WriteLine("\nCommande avec Livraison Express :");
            order.ProcessOrder(50);

            // 📦 Retrait en magasin
            order.SetShippingStrategy(new InStorePickup());
            Console.WriteLine("\nCommande avec Retrait en Magasin :");
            order.ProcessOrder(50);
        }
    }


}
