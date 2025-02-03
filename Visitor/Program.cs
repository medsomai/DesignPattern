namespace VisitorPatternExample
{

    // Interface des éléments visitables
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    // Classe concrète pour un paragraphe
    public class Paragraph : IElement
    {
        public string Text { get; set; }

        public Paragraph(string text)
        {
            Text = text;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitParagraph(this);
        }
    }

    // Classe concrète pour une image
    public class Image : IElement
    {
        public string Source { get; set; }

        public Image(string source)
        {
            Source = source;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitImage(this);
        }
    }

    // Interface des visiteurs
    public interface IVisitor
    {
        void VisitParagraph(Paragraph paragraph);
        void VisitImage(Image image);
    }

    // Visiteur pour l'export en HTML
    public class HtmlExportVisitor : IVisitor
    {
        public void VisitParagraph(Paragraph paragraph)
        {
            Console.WriteLine($"<p>{paragraph.Text}</p>");
        }

        public void VisitImage(Image image)
        {
            Console.WriteLine($"<img src='{image.Source}' />");
        }
    }

    // Visiteur pour la génération de statistiques
    public class StatisticsVisitor : IVisitor
    {
        private int _paragraphCount = 0;
        private int _imageCount = 0;

        public void VisitParagraph(Paragraph paragraph)
        {
            _paragraphCount++;
        }

        public void VisitImage(Image image)
        {
            _imageCount++;
        }

        public void PrintStatistics()
        {
            Console.WriteLine($"Nombre de paragraphes : {_paragraphCount}");
            Console.WriteLine($"Nombre d'images : {_imageCount}");
        }
    }

    // Structure de données (par exemple, un document)
    public class Document
    {
        private List<IElement> _elements = new List<IElement>();

        public void AddElement(IElement element)
        {
            _elements.Add(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }

    // Client
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'un document avec des éléments
            Document document = new Document();
            document.AddElement(new Paragraph("Ceci est un paragraphe."));
            document.AddElement(new Image("image1.jpg"));
            document.AddElement(new Paragraph("Un autre paragraphe."));

            // Export en HTML
            HtmlExportVisitor htmlExportVisitor = new HtmlExportVisitor();
            document.Accept(htmlExportVisitor);

            Console.WriteLine();

            // Génération de statistiques
            StatisticsVisitor statisticsVisitor = new StatisticsVisitor();
            document.Accept(statisticsVisitor);
            statisticsVisitor.PrintStatistics();
        }
    }
}
