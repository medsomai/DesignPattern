namespace DecoratorPatternExample
{
    // Interface commune pour les composants de message
    public interface IMessage
    {
        string GetContent();
    }

    // Composant de base : Message brut
    public class PlainMessage : IMessage
    {
        private readonly string _content;

        public PlainMessage(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }
    }

    // Classe de base pour les décorateurs
    public abstract class MessageDecorator : IMessage
    {
        protected readonly IMessage Message;

        protected MessageDecorator(IMessage message)
        {
            Message = message;
        }

        public abstract string GetContent();
    }

    // Décorateur : Compression
    public class CompressedMessage : MessageDecorator
    {
        public CompressedMessage(IMessage message) : base(message) { }

        public override string GetContent()
        {
            var content = Message.GetContent();
            return $"[Compressed] {content}";
        }
    }

    // Décorateur : Chiffrement
    public class EncryptedMessage : MessageDecorator
    {
        public EncryptedMessage(IMessage message) : base(message) { }

        public override string GetContent()
        {
            var content = Message.GetContent();
            return $"[Encrypted] {content}";
        }
    }

    // Décorateur : Signature
    public class SignedMessage : MessageDecorator
    {
        private readonly string _signature;

        public SignedMessage(IMessage message, string signature) : base(message)
        {
            _signature = signature;
        }

        public override string GetContent()
        {
            var content = Message.GetContent();
            return $"{content}\nSignature : {_signature}";
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Message brut
            IMessage message = new PlainMessage("Hello, World!");

            // Ajouter une compression
            message = new CompressedMessage(message);

            // Ajouter un chiffrement
            message = new EncryptedMessage(message);

            // Ajouter une signature
            message = new SignedMessage(message, "Med SOMAI");

            // Afficher le contenu final
            Console.WriteLine(message.GetContent());
        }
    }
}
