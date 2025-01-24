namespace ChainOfResponsibilityPatternExample
{
    // Classe représentant une requête
    public class SupportRequest
    {
        public string Type { get; }
        public string Description { get; }

        public SupportRequest(string type, string description)
        {
            Type = type;
            Description = description;
        }
    }

    // Interface de base pour les gestionnaires
    public abstract class SupportHandler
    {
        protected SupportHandler _nextHandler;

        public void SetNext(SupportHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void Handle(SupportRequest request)
        {
            if (CanHandle(request))
            {
                ProcessRequest(request);
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
            else
            {
                Console.WriteLine($"No handler found for request type: {request.Type}");
            }
        }

        protected abstract bool CanHandle(SupportRequest request);
        protected abstract void ProcessRequest(SupportRequest request);
    }

    // Gestionnaire pour le support technique basique
    public class BasicSupportHandler : SupportHandler
    {
        protected override bool CanHandle(SupportRequest request)
        {
            return request.Type == "Basic";
        }

        protected override void ProcessRequest(SupportRequest request)
        {
            Console.WriteLine($"Basic Support: Handling request - {request.Description}");
        }
    }

    // Gestionnaire pour la facturation
    public class BillingSupportHandler : SupportHandler
    {
        protected override bool CanHandle(SupportRequest request)
        {
            return request.Type == "Billing";
        }

        protected override void ProcessRequest(SupportRequest request)
        {
            Console.WriteLine($"Billing Support: Handling request - {request.Description}");
        }
    }

    // Gestionnaire pour le support technique avancé
    public class AdvancedSupportHandler : SupportHandler
    {
        protected override bool CanHandle(SupportRequest request)
        {
            return request.Type == "Advanced";
        }

        protected override void ProcessRequest(SupportRequest request)
        {
            Console.WriteLine($"Advanced Support: Handling request - {request.Description}");
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Configuration de la chaîne
            var basicHandler = new BasicSupportHandler();
            var billingHandler = new BillingSupportHandler();
            var advancedHandler = new AdvancedSupportHandler();

            basicHandler.SetNext(billingHandler);
            billingHandler.SetNext(advancedHandler);

            // Création de requêtes
            var requests = new[]
            {
                new SupportRequest("Basic", "Forgot password"),
                new SupportRequest("Billing", "Incorrect invoice"),
                new SupportRequest("Advanced", "System crash on startup"),
                new SupportRequest("Unknown", "Undefined request type")
            };

            // Traitement des requêtes
            foreach (var request in requests)
            {
                basicHandler.Handle(request);
            }
        }
    }
}
