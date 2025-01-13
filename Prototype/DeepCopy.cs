using System.Text.Json;

namespace DeepCopyExample
{
    // Classe complexe avec des références imbriquées
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Hobbies { get; set; } = new List<string>();

        // Méthode de clonage profond via sérialisation
        public Person DeepCopy()
        {
            // Sérialisation en JSON
            var json = JsonSerializer.Serialize(this);

            // Désérialisation pour créer une nouvelle instance
            return JsonSerializer.Deserialize<Person>(json);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Hobbies: {string.Join(", ", Hobbies)}";
        }
    }
}
