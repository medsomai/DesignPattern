namespace IteratorPatternExample
{
    // Classe représentant un livre
    public class Book
    {
        public string Title { get; }

        public Book(string title)
        {
            Title = title;
        }
    }

    // Interface de l'itérateur
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    // Interface de la collection itérable
    public interface IIterableCollection<T>
    {
        IIterator<T> CreateIterator();
    }

    // Implémentation de l'itérateur pour la bibliothèque de livres
    public class BookIterator : IIterator<Book>
    {
        private readonly List<Book> _books;
        private int _position = 0;

        public BookIterator(List<Book> books)
        {
            _books = books;
        }

        public bool HasNext()
        {
            return _position < _books.Count;
        }

        public Book Next() => HasNext() ? _books[_position++] : null;
    }

    // Collection de livres qui implémente l'interface de collection itérable
    public class Library : IIterableCollection<Book>
    {
        private readonly List<Book> _books = new();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public IIterator<Book> CreateIterator()
        {
            return new BookIterator(_books);
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Création de la bibliothèque
            var library = new Library();
            library.AddBook(new Book("Design Patterns"));
            library.AddBook(new Book("Clean Code"));
            library.AddBook(new Book("The Pragmatic Programmer"));

            // Récupération de l'itérateur
            var iterator = library.CreateIterator();

            // Parcours des livres avec l'itérateur
            while (iterator.HasNext())
            {
                Console.WriteLine("Book: " + iterator.Next().Title);
            }
        }
    }
}
