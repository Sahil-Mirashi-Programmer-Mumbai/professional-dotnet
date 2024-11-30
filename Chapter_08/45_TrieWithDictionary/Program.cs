/*
Program to demonstrate Trie with Dictionary in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: A Trie is a tree - like structure useful for efficient text search.
Application: Auto - completion, spell - checking, and text prediction.
*/

namespace TrieWithDictionary
{
    class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        public bool IsEndOfWord = false;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Trie with Dictionary in C# with Visual Studio\n");

            TrieNode root = new TrieNode();

            // Add words to the Trie
            AddWord(root, "cat");
            AddWord(root, "car");
            AddWord(root, "cart");

            // Check if words exist
            Console.WriteLine($"Does 'cat' exist? {SearchWord(root, "cat")}");
            Console.WriteLine($"Does 'cap' exist? {SearchWord(root, "cap")}");

            // Adding word to the Trie
            void AddWord(TrieNode node, string word)
            {
                TrieNode current = node;
                foreach (var c in word)
                {
                    if (!current.Children.ContainsKey(c))
                        current.Children[c] = new TrieNode();
                    current = current.Children[c];
                }
                current.IsEndOfWord = true;
            }

            // Searching for a word
            bool SearchWord(TrieNode node, string word)
            {
                TrieNode current = node;
                foreach (var c in word)
                {
                    if (!current.Children.ContainsKey(c))
                        return false;
                    current = current.Children[c];
                }
                return current.IsEndOfWord;
            }
        }
    }
}