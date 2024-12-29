/*
Proxy Design Pattern

Definition:
The Proxy design pattern is a structural design pattern that provides a placeholder or surrogate object to control access to another object.
It allows additional functionality, such as lazy initialization, access control, logging, or caching, without modifying the actual object's code.
*/

// Subject Interface
public interface IImage
{
    void Display(); // Common method for real and proxy objects
}

// Real Subject Class
public class RealImage : IImage
{
    private readonly string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk(); // Simulate a costly operation
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"Loading image from disk: {_fileName}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying image: {_fileName}");
    }
}

// Proxy Class
public class ProxyImage : IImage
{
    private RealImage _realImage; // Holds a reference to the real object
    private readonly string _fileName;

    public ProxyImage(string fileName)
    {
        _fileName = fileName; // Stores file name for lazy initialization
    }

    public void Display()
    {
        if (_realImage == null)
        {
            // Lazy initialization of the real object
            _realImage = new RealImage(_fileName);
        }
        _realImage.Display(); // Delegates the request to the real object
    }
}

// Client Code
class Program
{
    static void Main(string[] args)
    {
        IImage image1 = new ProxyImage("Photo1.jpg");
        IImage image2 = new ProxyImage("Photo2.jpg");

        // Image1 is loaded from disk only when it's displayed for the first time
        image1.Display();
        Console.WriteLine();

        // Image1 is not loaded again; only Display() is called
        image1.Display();
        Console.WriteLine();

        // Image2 is loaded from disk when it's displayed for the first time
        image2.Display();
    }
}

/*
Code Explanation
Subject Interface (IImage):
Defines the common interface for both the real object(RealImage) and the proxy object(ProxyImage).
Ensures the client can use either the proxy or the real object interchangeably.

Real Subject(RealImage):
Implements the IImage interface.
Simulates a costly operation (LoadFromDisk()) during object creation.
Contains the core logic for the Display() method.

Proxy (ProxyImage):
Implements the same interface (IImage) as the real subject.
Maintains a reference to the real subject (_realImage) and performs lazy initialization.
Delegates method calls to the real object when needed.
Adds additional behavior, such as controlling when and how the real object is instantiated.

Client Code:
The client interacts with the proxy (ProxyImage) instead of the real object (RealImage).
The proxy ensures that the real object is loaded from disk only when required, thereby optimizing performance.
*/