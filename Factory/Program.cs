namespace FactoryPatternExample
{
    // Interface commune pour les documents
    public interface IDocument
    {
        void Open();
    }

    // Implémentations concrètes des documents
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a PDF document...");
        }
    }

    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a Word document...");
        }
    }

    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening an Excel document...");
        }
    }

    // Fabrique qui crée des documents
    public class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
        {
            switch (type.ToLower())
            {
                case "pdf":
                    return new PdfDocument();
                case "word":
                    return new WordDocument();
                case "excel":
                    return new ExcelDocument();
                default:
                    throw new ArgumentException("Invalid document type");
            }
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Création des documents via la fabrique
            IDocument pdfDoc = DocumentFactory.CreateDocument("pdf");
            IDocument wordDoc = DocumentFactory.CreateDocument("word");

            // Utilisation des documents
            pdfDoc.Open();  // Output: Opening a PDF document...
            wordDoc.Open(); // Output: Opening a Word document...
        }
    }
}
