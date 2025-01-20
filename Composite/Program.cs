namespace CompositePatternExample
{
    // Interface commune pour les composants du système de fichiers
    public interface IFileSystemComponent
    {
        string Name { get; }
        void Display(string indent = "");
        long GetSize();
    }

    // Classe pour un fichier (composant feuille)
    public class File : IFileSystemComponent
    {
        public string Name { get; }
        public long Size { get; }

        public File(string name, long size)
        {
            Name = name;
            Size = size;
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}- File: {Name} ({Size} bytes)");
        }

        public long GetSize()
        {
            return Size;
        }
    }

    // Classe pour un dossier (composant composite)
    public class Folder : IFileSystemComponent
    {
        public string Name { get; }
        private readonly List<IFileSystemComponent> _children = [];

        public Folder(string name)
        {
            Name = name;
        }

        public void Add(IFileSystemComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IFileSystemComponent component)
        {
            _children.Remove(component);
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}+ Folder: {Name}");
            foreach (var child in _children)
            {
                child.Display(indent + "  ");
            }
        }

        public long GetSize()
        {
            long totalSize = 0;
            foreach (var child in _children)
            {
                totalSize += child.GetSize();
            }
            return totalSize;
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Fichiers individuels
            var file1 = new File("File1.txt", 500);
            var file2 = new File("File2.txt", 800);
            var file3 = new File("File3.txt", 300);

            // Dossiers
            var folder1 = new Folder("Documents");
            folder1.Add(file1);
            folder1.Add(file2);

            var folder2 = new Folder("Pictures");
            folder2.Add(file3);

            var root = new Folder("Root");
            root.Add(folder1);
            root.Add(folder2);

            // Afficher le contenu du système de fichiers
            root.Display();

            // Calculer la taille totale
            Console.WriteLine($"Total size: {root.GetSize()} bytes");
        }
    }
}
