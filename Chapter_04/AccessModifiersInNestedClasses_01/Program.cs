// Program to demonstrate Access Modifiers In Nested Classes in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace AccessModifiersInNestedClasses_01
{
    class OuterClass
    {
        private class InnerClass
        {
            // Private method within nested class
            public void InnerClassMethod()
            {
                Console.WriteLine("Inner Class Method");
            }
        }

        public void AccessInnerClass()
        {
            InnerClass innerClass = new InnerClass();
            innerClass.InnerClassMethod(); // Accessing private nested class method
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Access Modifiers In Nested Classes in C# with Visual Studio\n");

            OuterClass outerClass = new OuterClass();
            outerClass.AccessInnerClass(); // Output: Inner Class Method
        }
    }
}
