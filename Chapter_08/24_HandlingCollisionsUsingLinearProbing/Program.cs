// Program to demonstrate Handling Collisions using Linear Probing in C# with Visual Studio
// Programmer: Sahil Mirashi

/* 
 Explanation:
 - "Linear probing" is a collision resolution technique used in hash tables.
 - When a collision occurs (i.e., two keys hash to the same index), we linearly probe the next slot.
 - This ensures the data is still inserted and helps maintain efficient access times.
 - Application: Linear probing is useful when a hash table must maintain contiguous space utilization.
 */

namespace _24_HandlingCollisionsUsingLinearProbing
{
    class Program
    {
        // Hash table class using linear probing for collision resolution
        class HashTable
        {
            private int[] table;
            private int tableSize;

            public HashTable(int size)
            {
                tableSize = size;
                table = new int[tableSize];
                for (int i = 0; i < tableSize; i++)
                {
                    // Initialize all slots to -1 indicating empty slots
                    table[i] = -1;
                }
            }

            // Hash function to calculate hash index
            private int HashFunction(int key)
            {
                return key % tableSize;
            }

            // Insert method using linear probing
            public void Insert(int key)
            {
                int hashIndex = HashFunction(key);

                // Handle collisions by linear probing
                while (table[hashIndex] != -1)
                {
                    hashIndex = (hashIndex + 1) % tableSize; // Move to the next slot
                }

                // Insert the key at the determined index
                table[hashIndex] = key;
            }

            // Display the hash table
            public void Display()
            {
                for (int i = 0; i < tableSize; i++)
                {
                    Console.WriteLine($"Index {i}: {table[i]}");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Handling Collisions using Linear Probing in C# with Visual Studio\n");

            HashTable hashTable = new HashTable(4);
            int[] keys = { 50, 700, 76, 85 };
            // Insert keys into the hash table
            foreach (int key in keys)
            {
                hashTable.Insert(key);
            }

            // Display the final hash table
            Console.WriteLine("Hash Table:");
            hashTable.Display();
        }
    }
}
