namespace AdapterPatternExample
{
    // Interface cible attendue par le client
    public interface IContact
    {
        string GetFullName();
        string GetEmail();
    }

    // Classe existante
    public class Contact : IContact
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string Email { get; set; } = string.Empty;

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetEmail()
        {
            return Email;
        }
    }

    // Classe externe incompatible avec IContact
    public class ExternalContact
    {
        public required string FullName { get; set; }
        public string ContactEmail { get; set; } = string.Empty;
    }

    // Adapter qui rend ExternalContact compatible avec IContact
    public class ExternalContactAdapter : IContact
    {
        private readonly ExternalContact _externalContact;

        public ExternalContactAdapter(ExternalContact externalContact)
        {
            _externalContact = externalContact;
        }

        public string GetFullName()
        {
            return _externalContact.FullName;
        }

        public string GetEmail()
        {
            return _externalContact.ContactEmail;
        }
    }

    // Client qui utilise l'interface IContact
    public class ContactManager
    {
        private readonly List<IContact> _contacts = new();

        public void AddContact(IContact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContacts()
        {
            foreach (var contact in _contacts)
            {
                Console.WriteLine($"Name: {contact.GetFullName()}, Email: {contact.GetEmail()}");
            }
        }
    }

    // Classe de test
    class Program
    {
        static void Main(string[] args)
        {
            // Contacts existants
            var contact1 = new Contact { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" };
            var contact2 = new Contact { FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com" };

            // Contact externe
            var externalContact = new ExternalContact { FullName = "Alice Johnson", ContactEmail = "alice.johnson@external.com" };

            // Utilisation du ContactManager
            var manager = new ContactManager();

            // Ajouter des contacts compatibles
            manager.AddContact(contact1);
            manager.AddContact(contact2);

            // Adapter le contact externe et l'ajouter
            var adaptedContact = new ExternalContactAdapter(externalContact);
            manager.AddContact(adaptedContact);

            // Afficher tous les contacts
            manager.DisplayContacts();
        }
    }
}
