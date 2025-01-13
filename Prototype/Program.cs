using DeepCopyExample;

namespace PrototypePatternExample
{
    // Interface pour le clonage
    public interface IShape
    {
        IShape Clone();
        void Display();
    }

    // Classe concrète : Cercle
    public class Circle : IShape
    {
        public int Radius { get; set; }
        public string Color { get; set; }

        public IShape Clone()
        {
            // Clonage superficiel (shallow copy)
            return (IShape)this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Circle with Radius: {Radius}, Color: {Color}");
        }
    }

    // Classe concrète : Rectangle
    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }

        public IShape Clone()
        {
            // Clonage superficiel (shallow copy)
            return (IShape)this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Rectangle with Width: {Width}, Height: {Height}, Color: {Color}");
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'un cercle prototype
            Circle circlePrototype = new Circle { Radius = 10, Color = "Red" };

            // Création d'un rectangle prototype
            Rectangle rectanglePrototype = new Rectangle { Width = 20, Height = 10, Color = "Blue" };

            // Clonage des prototypes et modification des copies
            IShape clonedCircle = circlePrototype.Clone();
            clonedCircle.Display(); // Circle with Radius: 10, Color: Red

            IShape anotherClonedCircle = circlePrototype.Clone();
            ((Circle)anotherClonedCircle).Radius = 15;
            anotherClonedCircle.Display(); // Circle with Radius: 15, Color: Red

            IShape clonedRectangle = rectanglePrototype.Clone();
            clonedRectangle.Display(); // Rectangle with Width: 20, Height: 10, Color: Blue

            ((Rectangle)clonedRectangle).Color = "Green";
            clonedRectangle.Display(); // Rectangle with Width: 20, Height: 10, Color: Green


            // test Deep Copy //

            // Création d'un objet Person
            Person original = new Person
            {
                Name = "John Doe",
                Age = 30,
                Hobbies = new List<string> { "Reading", "Cycling" }
            };

            // Clonage profond
            Person clone = original.DeepCopy();

            // Modification de la copie
            clone.Name = "Jane Doe";
            clone.Hobbies.Add("Swimming");

            // Affichage des deux objets
            Console.WriteLine("Original: " + original); // Name: John Doe, Age: 30, Hobbies: Reading, Cycling
            Console.WriteLine("Clone: " + clone);       // Name: Jane Doe, Age: 30, Hobbies: Reading, Cycling, Swimming
        }
    }
}
