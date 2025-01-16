namespace BridgePatternExample
{
    // Interface pour l'implémentation (moteur de rendu)
    public interface IRenderer
    {
        void Render(string shape);
    }

    // Implémentation concrète : Rendu en 2D
    public class Renderer2D : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Rendering {shape} in 2D.");
        }
    }

    // Implémentation concrète : Rendu en 3D
    public class Renderer3D : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Rendering {shape} in 3D.");
        }
    }

    // Classe abstraite pour les formes
    public abstract class Shape
    {
        protected IRenderer Renderer;

        protected Shape(IRenderer renderer)
        {
            Renderer = renderer;
        }

        public abstract void Draw();
    }

    // Forme concrète : Cercle
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(IRenderer renderer, double radius) : base(renderer)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Renderer.Render($"Circle with radius {Radius}");
        }
    }

    // Forme concrète : Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(IRenderer renderer, double width, double height) : base(renderer)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Renderer.Render($"Rectangle with width {Width} and height {Height}");
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Rendu en 2D
            IRenderer renderer2D = new Renderer2D();

            // Rendu en 3D
            IRenderer renderer3D = new Renderer3D();

            // Dessiner un cercle en 2D
            Shape circle2D = new Circle(renderer2D, 5);
            circle2D.Draw(); // Output: Rendering Circle with radius 5 in 2D.

            // Dessiner un rectangle en 3D
            Shape rectangle3D = new Rectangle(renderer3D, 10, 20);
            rectangle3D.Draw(); // Output: Rendering Rectangle with width 10 and height 20 in 3D.

            // Changer dynamiquement le moteur de rendu
            Shape circle3D = new Circle(renderer3D, 7);
            circle3D.Draw(); // Output: Rendering Circle with radius 7 in 3D.
        }
    }
}
