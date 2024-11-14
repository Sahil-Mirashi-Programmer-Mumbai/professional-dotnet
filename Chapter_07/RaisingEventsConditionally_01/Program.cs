// Program to demonstrate Raising Events Conditionally in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Conditional Event Raising: Events triggered based on logic.
    Monitoring Scenarios: Useful in monitoring thresholds and conditions.
*/

namespace RaisingEventsConditionally_01
{
    public class ThresholdMonitor
    {
        public event EventHandler ThresholdReached;

        private int _threshold;
        private int _counter;

        public ThresholdMonitor(int threshold)
        {
            _threshold = threshold;
        }

        public void Add(int value)
        {
            _counter += value;
            if (_counter >= _threshold)
            {
                ThresholdReached?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Raising Events Conditionally in C# with Visual Studio\n");

            ThresholdMonitor monitor = new ThresholdMonitor(10);

            // Subscribing to the event
            monitor.ThresholdReached += OnThresholdReached;

            // Adding values
            monitor.Add(3);
            monitor.Add(7); // Output: Threshold reached!
        }

        private static void OnThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("Threshold reached!");
        }
    }
}
