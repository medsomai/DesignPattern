namespace TemplateMethodPatternExample
{
    public abstract class OrderProcessor
    {
        // Méthode Template définissant l'algorithme global
        public void ProcessOrder()
        {
            SelectItem();
            ProcessPayment();
            ShipOrder();
            Console.WriteLine("Commande terminée.\n");
        }

        // Étapes communes
        protected void SelectItem()
        {
            Console.WriteLine("Article sélectionné.");
        }

        protected void ShipOrder()
        {
            Console.WriteLine("Commande expédiée.");
        }

        // Étape spécifique (méthode abstraite, doit être implémentée par les sous-classes)
        protected abstract void ProcessPayment();
    }

    public class CreditCardOrder : OrderProcessor
    {
        protected override void ProcessPayment()
        {
            Console.WriteLine("Paiement effectué par carte bancaire.");
        }
    }

    public class PayPalOrder : OrderProcessor
    {
        protected override void ProcessPayment()
        {
            Console.WriteLine("Paiement effectué via PayPal.");
        }
    }

    public class CryptoOrder : OrderProcessor
    {
        protected override void ProcessPayment()
        {
            Console.WriteLine("Paiement effectué en crypto-monnaie.");
        }
    }

    class Program
    {
        static void Main()
        {
            OrderProcessor order1 = new CreditCardOrder();
            Console.WriteLine("Traitement d'une commande avec carte bancaire :");
            order1.ProcessOrder();

            OrderProcessor order2 = new PayPalOrder();
            Console.WriteLine("Traitement d'une commande avec PayPal :");
            order2.ProcessOrder();

            OrderProcessor order3 = new CryptoOrder();
            Console.WriteLine("Traitement d'une commande avec crypto-monnaie :");
            order3.ProcessOrder();
        }
    }
}
