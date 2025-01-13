namespace SingletonPatternExample
{
    // Classe Singleton
    public class Logger
    {
        // Instance unique de la classe (initialisation paresseuse avec Lazy<T>)
        private static readonly Lazy<Logger> _instance = new(() => new Logger());

        // Propriété pour accéder à l'instance
        public static Logger Instance => _instance.Value;

        // Constructeur privé pour empêcher l'instanciation directe
        private Logger()
        {
            Console.WriteLine("Logger initialized.");
        }

        // Méthode pour écrire un message dans les journaux
        public void Log(string message)
        {
            Console.WriteLine($"[Log]: {message}");
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Accéder à l'instance unique du Logger
            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            // Vérifier que les deux instances sont les mêmes
            Console.WriteLine(Object.ReferenceEquals(logger1, logger2)); // True

            // Utiliser le Logger
            logger1.Log("Singleton pattern in action.");
            logger2.Log("This is the same instance.");
        }
    }
}
