/*
Definition:
The Composite Pattern allows you to compose objects into tree structures to represent part-whole hierarchies.
It lets clients treat individual objects and compositions of objects uniformly.

Applications:
When objects need to be grouped into tree structures.
When you want to treat a group of objects as a single object.
*/

namespace CompositePatternExample
{
    // Component interface
    public interface IFileSystemItem
    {
        void Display(string indent);
    }

    // Leaf
    public class File : IFileSystemItem
    {
        public string Name { get; }

        public File(string name)
        {
            Name = name;
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}- {Name}");
        }
    }

    // Composite
    public class Directory : IFileSystemItem
    {
        public string Name { get; }
        private List<IFileSystemItem> _items = new List<IFileSystemItem>();

        public Directory(string name)
        {
            Name = name;
        }

        public void AddItem(IFileSystemItem item)
        {
            _items.Add(item);
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}+ {Name}");
            foreach (var item in _items)
            {
                item.Display(indent + "  ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create leaf nodes
            File file1 = new File("File1.txt");
            File file2 = new File("File2.txt");

            // Create composite nodes
            Directory subDir = new Directory("SubDirectory");
            subDir.AddItem(file1);

            Directory rootDir = new Directory("RootDirectory");
            rootDir.AddItem(subDir);
            rootDir.AddItem(file2);

            // Display hierarchy
            rootDir.Display("");

            Console.ReadLine();
        }
    }
}

/*
Explanation of Code:

Component (IFileSystemItem):
Declares common operations for both leaf and composite objects.

Leaf (File):
Represents individual objects with no children.

Composite (Directory):
Contains child components and implements operations for managing them.

Client (Main Method):
Builds a tree structure and operates on it uniformly.
*/