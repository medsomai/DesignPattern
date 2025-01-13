using System;

namespace AbstractFactoryPatternExample
{
    // Interface pour les documents
    public interface IDocument
    {
        void Open();
    }

    // Variantes concrètes des documents
    public class HighQualityPdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a high-quality PDF document...");
        }
    }

    public class FastPdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a fast-rendering PDF document...");
        }
    }

    public class HighQualityWordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a high-quality Word document...");
        }
    }

    public class FastWordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a fast-rendering Word document...");
        }
    }

    // Interface pour les fabriques abstraites
    public interface IDocumentFactory
    {
        IDocument CreatePdfDocument();
        IDocument CreateWordDocument();
    }

    // Fabrique concrète pour les documents haute qualité
    public class HighQualityDocumentFactory : IDocumentFactory
    {
        public IDocument CreatePdfDocument()
        {
            return new HighQualityPdfDocument();
        }

        public IDocument CreateWordDocument()
        {
            return new HighQualityWordDocument();
        }
    }

    // Fabrique concrète pour les documents rapides
    public class FastDocumentFactory : IDocumentFactory
    {
        public IDocument CreatePdfDocument()
        {
            return new FastPdfDocument();
        }

        public IDocument CreateWordDocument()
        {
            return new FastWordDocument();
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Choisir une fabrique (par exemple, haute qualité ou rapide)
            IDocumentFactory highQualityFactory = new HighQualityDocumentFactory();
            IDocumentFactory fastFactory = new FastDocumentFactory();

            // Créer des documents via la fabrique
            IDocument highQualityPdf = highQualityFactory.CreatePdfDocument();
            IDocument fastWord = fastFactory.CreateWordDocument();

            // Utilisation des documents
            highQualityPdf.Open();  // Output: Opening a high-quality PDF document...
            fastWord.Open();        // Output: Opening a fast-rendering Word document...
        }
    }
}
