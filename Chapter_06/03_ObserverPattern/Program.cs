/*
Definition:
The Observer Pattern defines a dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

Why it is used:
To decouple the subject from its observers, allowing the subject to update all interested parties without needing to know who they are.
*/

namespace ObserverPattern
{
    // Subject class
    public class WeatherStation
    {
        private List<IObserver> _observers = new List<IObserver>();
        private float _temperature;

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void SetTemperature(float temperature)
        {
            _temperature = temperature;
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }
    }

    // Observer interface
    public interface IObserver
    {
        void Update(float temperature);
    }

    // Concrete Observer
    public class PhoneDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Phone Display: Current Temperature is {temperature}°C");
        }
    }

    // Concrete Observer
    public class DesktopDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Desktop Display: Current Temperature is {temperature}°C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating subject
            WeatherStation weatherStation = new WeatherStation();

            // Creating observers
            PhoneDisplay phoneDisplay = new PhoneDisplay();
            DesktopDisplay desktopDisplay = new DesktopDisplay();

            // Attach observers
            weatherStation.Attach(phoneDisplay);
            weatherStation.Attach(desktopDisplay);

            // Change temperature and notify observers
            weatherStation.SetTemperature(25);
        }
    }
}