// Program to demonstrate Generic List Class in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    MyList<T> is a generic class where T represents a type parameter, making the class usable for any data type.
    
    The class has methods Add and Get, which operate on items of type T.
    The main program demonstrates using MyList<int> for integers and MyList<string> for strings.
    Application: Generic classes like this are foundational in scenarios where a collection is needed but the data type may vary.
*/

namespace GenericListClass_01
{
    // Generic class GenericListClass where T is placeholder for a datatype
    class GenericListClass<T>
    {
        // Generic list
        private List<T> genericList = new List<T>();

        // Method to add item to generic list
        public void Add(T item)
        {
            genericList.Add(item);
        }

        // Method to get item from generic list by index
        public T Get(int index)
        {
            return genericList[index];
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Generic List Class in C# with Visual Studio\n");

            // Create instance of GenericListClass for integer type
            GenericListClass<int>  integerList = new GenericListClass<int>();
            integerList.Add(50);
            integerList.Add(70);
            Console.WriteLine("Integer List");
            Console.WriteLine(integerList.Get(0));
            Console.WriteLine(integerList.Get(1));

            // Create instance of GenericListClass for string type
            GenericListClass<string> stringList = new GenericListClass<string>();
            Console.WriteLine("String List");
            stringList.Add("Hello");
            stringList.Add("World");
            Console.WriteLine(stringList.Get(0));
            Console.WriteLine(stringList.Get(1));
        }
    }
}
