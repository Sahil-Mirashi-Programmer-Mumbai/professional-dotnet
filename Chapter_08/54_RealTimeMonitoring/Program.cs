/*
Program to demonstrate Real Time Monitoring in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Sets manage dynamic data like active users efficiently.
Application: Tracking online users in real-time systems.
*/

namespace RealTimeMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Real Time Monitoring in C# with Visual Studio\n");

            HashSet<string> activeUsers = new HashSet<string>();
            activeUsers.Add("User1");
            activeUsers.Add("User2");
            activeUsers.Remove("User1");

            Console.WriteLine("Active Users:");
            foreach (var user in activeUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}