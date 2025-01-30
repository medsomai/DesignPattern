namespace MediatorPatternExample
{
    // 🏠  Interface du Médiateur
    public interface IChatMediator
    {
        void RegisterUser(User user);
        void SendMessage(string message, User sender);
    }

    // 🏢 Implémentation du Médiateur
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users = new();

        public void RegisterUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                // Éviter d'envoyer un message à soi-même
                if (user != sender)
                {
                    user.ReceiveMessage(message, sender);
                }
            }
        }
    }

    // 👥 Classe de base pour les utilisateurs
    public abstract class User
    {
        protected IChatMediator Mediator;
        public string Name { get; }

        public User(IChatMediator mediator, string name)
        {
            Mediator = mediator;
            Name = name;
        }

        public abstract void SendMessage(string message);
        public abstract void ReceiveMessage(string message, User sender);
    }

    // 🧑‍💻 Utilisateur Concret du Chat
    public class ChatUser : User
    {
        public ChatUser(IChatMediator mediator, string name) : base(mediator, name) { }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"{Name} envoie : {message}");
            Mediator.SendMessage(message, this);
        }

        public override void ReceiveMessage(string message, User sender)
        {
            Console.WriteLine($"{Name} reçoit de {sender.Name} : {message}");
        }
    }

    // 🚀 Programme de test
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();

            User alice = new ChatUser(chatMediator, "Alice");
            User bob = new ChatUser(chatMediator, "Bob");
            User charlie = new ChatUser(chatMediator, "Charlie");

            chatMediator.RegisterUser(alice);
            chatMediator.RegisterUser(bob);
            chatMediator.RegisterUser(charlie);

            // 📢 Simulation de messages
            alice.SendMessage("Bonjour tout le monde !");
            bob.SendMessage("Salut Alice !");
            charlie.SendMessage("Hey !");
        }
    }
}
