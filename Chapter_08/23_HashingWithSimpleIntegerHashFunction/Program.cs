// Program to demonstrate Hashing with Simple Integer Hash Function in C# with Visual Studio
// Programmer: Sahil Mirashi

/* 
 Explanation:
 - A "hash function" is used to map input data (in this case, integer keys) to a fixed-size value (hash index).
 - The simple hash function here computes the index by taking the modulus of the key with the table size.
 - Application: This is useful in creating hash tables for quick data retrieval.
 - Hashing helps to distribute data evenly across storage slots, minimizing search time.
 */


namespace _23_HashingWithSimpleIntegerHashFunction
{
    class Program
    {
        // Simple hash function for integer values
        public static int SimpleHashFunction(int key, int tableSize)
        {
            // Calculate hash index by taking modulus of key with table size
            return key % tableSize;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Hashing with Simple Integer Hash Function in C# with Visual Studio\n");

            // Example integer keys to hash
            int[] keys = { 23, 42, 56, 72, 91 };
            // Size of the hash table (array size)
            int tableSize = 10;

            Console.WriteLine("Hash values for the given keys:");

            // Hash each key and print the resulting hash index
            foreach (int key in keys)
            {
                int hashValue = SimpleHashFunction(key, tableSize);
                Console.WriteLine($"Key: {key}, Hash Value: {hashValue}");
            }
        }
    }
}
