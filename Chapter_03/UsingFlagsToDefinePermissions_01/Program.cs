// Program to demonstrate Using Enum Flags to Define Permissions in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingFlagsToDefinePermissions_01
{
    // Define an enum with the Flags attribute to represent different user permissions
    [Flags]
    public enum UserPermissions
    {
        None = 0,         // No permissions
        Read = 1 << 0,    // Permission to read (1)
        Write = 1 << 1,   // Permission to write (2)
        Execute = 1 << 2, // Permission to execute (4)
        Delete = 1 << 3   // Permission to delete (8)
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using Enum Flags to Define Permissions in C# with Visual Studio\n");

            // Combine Read and Write permissions using bitwise OR
            // This user has both Read and Write permissions.
            UserPermissions user1Permissions = UserPermissions.Read | UserPermissions.Write;

            // Check if user1 has Write permission using bitwise AND
            // This will print "User has Write permission."
            if ((user1Permissions & UserPermissions.Write) == UserPermissions.Write)
            {
                Console.WriteLine("User has Write permission.");
            }

            Console.WriteLine("Removing Write permission of user1Permissions\n");
            // Remove Write permission using bitwise AND with NOT
            // This will remove the Write permission from user1.
            user1Permissions &= ~UserPermissions.Write;

            if ((user1Permissions & UserPermissions.Write) == UserPermissions.Write)
            {
                Console.WriteLine("User has Write permission.");
            }
            else
            {
                Console.WriteLine("User does not have Write permission.");
            }
        }
    }
}
