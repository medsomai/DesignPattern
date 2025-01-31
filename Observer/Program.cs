namespace ObserverPatternExample
{
    public interface IObserver
    {
        void Update(float temperature);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public class WeatherStation : ISubject
    {
        private List<IObserver> _observers = new();
        private float _temperature;

        public void SetTemperature(float temperature)
        {
            _temperature = temperature;
            Notify(); // Notifier tous les observateurs
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }
    }

    public class PhoneDisplay : IObserver
    {
        private string _name;

        public PhoneDisplay(string name)
        {
            _name = name;
        }

        public void Update(float temperature)
        {
            Console.WriteLine($"{_name} - Température mise à jour : {temperature}°C");
        }
    }

    public class ComputerDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Ordinateur - Nouvelle température : {temperature}°C");
        }
    }

    class Program
    {
        static void Main()
        {
            // Création du sujet (station météo)
            var weatherStation = new WeatherStation();

            // Création des observateurs
            var phoneDisplay1 = new PhoneDisplay("Téléphone 1");
            var phoneDisplay2 = new PhoneDisplay("Téléphone 2");
            var computerDisplay = new ComputerDisplay();

            // Attacher les observateurs
            weatherStation.Attach(phoneDisplay1);
            weatherStation.Attach(phoneDisplay2);
            weatherStation.Attach(computerDisplay);

            // Changement de température
            Console.WriteLine("Mise à jour de la température à 25°C...");
            weatherStation.SetTemperature(25);

            Console.WriteLine("\nMise à jour de la température à 30°C...");
            weatherStation.SetTemperature(30);

            // Détacher un observateur
            Console.WriteLine("\nTéléphone 1 se désabonne.");
            weatherStation.Detach(phoneDisplay1);

            Console.WriteLine("\nMise à jour de la température à 20°C...");
            weatherStation.SetTemperature(20);
        }
    }

}
