namespace ProxyPatternExample
{
    // Interface commune pour les documents
    public interface IDocument
    {
        string GetTitle();
        string GetContent();
    }

    // Document réel (coûteux à charger)
    public class RealDocument : IDocument
    {
        private readonly string _fileName;
        private readonly string _content;

        public RealDocument(string fileName)
        {
            _fileName = fileName;

            // Simulation d'une opération coûteuse
            Console.WriteLine($"Loading document from file: {_fileName}");
            _content = $"This is the content of {_fileName}";
        }

        public string GetTitle()
        {
            return $"Title of {_fileName}";
        }

        public string GetContent()
        {
            return _content;
        }
    }

    // Proxy pour le document
    public class DocumentProxy : IDocument
    {
        private readonly string _fileName;
        private RealDocument _realDocument;

        public DocumentProxy(string fileName)
        {
            _fileName = fileName;
        }

        public string GetTitle()
        {
            // Accès immédiat aux métadonnées
            return $"[Proxy] Title of {_fileName}";
        }

        public string GetContent()
        {
            // Chargement paresseux du contenu
            if (_realDocument == null)
            {
                _realDocument = new RealDocument(_fileName);
            }
            return _realDocument.GetContent();
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Création du proxy
            IDocument document = new DocumentProxy("example.pdf");

            // Accès au titre (sans charger le contenu)
            Console.WriteLine(document.GetTitle());

            // Accès au contenu (déclenche le chargement réel)
            Console.WriteLine(document.GetContent());
        }
    }
}
