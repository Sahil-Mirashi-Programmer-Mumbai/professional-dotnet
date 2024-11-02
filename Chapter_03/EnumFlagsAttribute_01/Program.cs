// Program to demonstrate Enum Flags Attribute in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace EnumFlagsAttribute_01
{
    // Enum named 'FilePermissions' with the [Flags] attribute.
    // The [Flags] attribute allows enum values to be combined using bitwise operations.
    enum FilePermission
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,
        All = Read | Write | Execute,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Enum Flags Attribute in C# with Visual Studio\n");

            // Combining multiple enum values using bitwise OR.
            FilePermission filePermission = FilePermission.Read | FilePermission.Write;

            // Checking if the combined value contains specific permissions.
            if ((filePermission & FilePermission.Read) == FilePermission.Read)
            {
                Console.WriteLine("Read permission granted");
            }

            if ((filePermission & FilePermission.Write) == FilePermission.Write)
            {
                Console.WriteLine("Write permission granted");
            }
        }
    }
}
