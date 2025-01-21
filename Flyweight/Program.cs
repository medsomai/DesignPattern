namespace FlyweightPatternExample
{
    // Classe représentant les données partagées (Flyweight)
    public class ShapeType
    {
        public string Color { get; }
        public string Shape { get; }

        public ShapeType(string shape, string color)
        {
            Shape = shape;
            Color = color;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing {Shape} in {Color} at position ({x}, {y}).");
        }
    }

    // Fabrique pour gérer les instances Flyweight
    public class ShapeFactory
    {
        private readonly Dictionary<string, ShapeType> _shapeTypes = new();

        public ShapeType GetShapeType(string shape, string color)
        {
            string key = $"{shape}_{color}";

            if (!_shapeTypes.ContainsKey(key))
            {
                _shapeTypes[key] = new ShapeType(shape, color);
                Console.WriteLine($"Created new ShapeType: {shape} in {color}");
            }

            return _shapeTypes[key];
        }
    }

    // Classe représentant les données spécifiques (non-partagées)
    public class Shape
    {
        public int X { get; }
        public int Y { get; }
        private readonly ShapeType _shapeType;

        public Shape(int x, int y, ShapeType shapeType)
        {
            X = x;
            Y = y;
            _shapeType = shapeType;
        }

        public void Draw()
        {
            _shapeType.Draw(X, Y);
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();

            // Création de formes
            var redCircle = shapeFactory.GetShapeType("Circle", "Red");
            var blueRectangle = shapeFactory.GetShapeType("Rectangle", "Blue");
            var redCircle2 = shapeFactory.GetShapeType("Circle", "Red"); // Instance partagée

            // Ajout des formes avec leurs données spécifiques
            var shapes = new List<Shape>
            {
                new Shape(10, 20, redCircle),
                new Shape(30, 40, blueRectangle),
                new Shape(50, 60, redCircle2) // Utilise l'instance partagée
            };

            // Dessiner les formes
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
