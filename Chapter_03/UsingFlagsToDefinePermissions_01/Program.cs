// Program to demonstrate Using Enum Flags to Define Permissions in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingFlagsToDefinePermissions_01
{
    // Define an enum with the Flags attribute to represent different user permissions
    [Flags]
    enum FilePermission
    {
        None = 1 << 0,
        Read = 1 << 1,
        Write = 1 << 2,
        Execute = 1 << 3
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using Enum Flags to Define Permissions in C# with Visual Studio\n");

            // Combine Read and Write permissions using bitwise OR
            // This user has both Read and Write permissions.
            FilePermission userPermissions = FilePermission.Read | FilePermission.Write;

            // Check if user1 has Write permission using bitwise AND
            // This will print "User has Write permission"
            if ((userPermissions & FilePermission.Write) == FilePermission.Write)
            {
                Console.WriteLine("User has write permission");
            }

            userPermissions = ~FilePermission.Write; // Removing write permission from user

            // This will print "User does not have write permission"
            if ((userPermissions & FilePermission.Write) == FilePermission.Write)
            {
                Console.WriteLine("User has write permission");
            }
            else
            {
                Console.WriteLine("User does not have write permission");
            }
        }
    }
}
