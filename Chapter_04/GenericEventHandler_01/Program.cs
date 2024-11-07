namespace GenericEventHandler_01
{
    // Event args class for custom events
    public class EventArgs<T> : EventArgs
    {
        public T Data { get; }

        public EventArgs(T data)
        {
            Data = data;
        }
    }

    // Publisher class with generic event handler
    public class Publisher<T>
    {
        public event EventHandler<EventArgs<T>> OnDataReceived; // Publisher class with generic event handler Publisher class with generic event handlerPublisher class with generic event handler

        public void PublishData(T data)
        {
            OnDataReceived?.Invoke(this, new EventArgs<T>(data));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Publisher<int> intPublisher = new Publisher<int>();
            intPublisher.OnDataReceived += (sender, e) => Console.WriteLine($"Integer Data Received: {e.Data}");

            Publisher<string> stringPublisher = new Publisher<string>();
            stringPublisher.OnDataReceived += (sender, e) => Console.WriteLine($"String Data Received: {e.Data}");

            intPublisher.PublishData(42);
            stringPublisher.PublishData("Hello, world!");
        }
    }
}
