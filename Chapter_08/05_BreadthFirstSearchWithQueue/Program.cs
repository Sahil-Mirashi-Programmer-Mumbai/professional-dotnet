// Program to demonstrate Breadth First Search with Queue in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    This example demonstrates using a queue for Breadth - First Search(BFS) in a graph.
    BFS is useful in scenarios such as shortest path finding, web crawlers, etc.
    Shows how queues are essential for exploring elements in a level - order manner.
*/


/*
    Graph Representation: 
    The graph is represented as an adjacency list using a Dictionary< int, List<int> >, where the keys are nodes, and the values are lists of neighboring nodes.
    
    Queue: A queue is used to maintain the order of nodes to be visited, ensuring a breadth-first traversal.
    
    Visited Set: A HashSet keeps track of nodes that have already been visited to prevent revisiting the same node.
    
    Core BFS Logic:
    Nodes are dequeued from the queue for processing.
    All unvisited neighbors of the dequeued node are enqueued and marked as visited.
    
    Traversal Order: The BFS traversal starts from node 0 and explores all reachable nodes level by level.
*/

namespace _05_BreadthFirstSearchWithQueue // Defines a namespace for organizing the code into a logical grouping.
{
    class Program // Declares the main class of the program.
    {
        static void Main(string[] args) // Entry point of the application, where the program starts execution.
        {
            Console.WriteLine("Program to demonstrate Breadth First Search with Queue in C# with Visual Studio\n");

            // Graph represented as an adjacency list
            // Create a dictionary to store the adjacency list of the graph.
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>
            {
                { 0, new List<int> { 1, 2 } }, // Node 0 is connected to nodes 1 and 2.
                { 1, new List<int> { 0, 3, 4 } }, // Node 1 is connected to nodes 0, 3, and 4.
                { 2, new List<int> { 0, 5, 6 } }, // Node 2 is connected to nodes 0, 5, and 6.
                { 3, new List<int> { 1 } }, // Node 3 is connected to node 1.
                { 4, new List<int> { 1 } }, // Node 4 is connected to node 1.
                { 5, new List<int> { 2 } }, // Node 5 is connected to node 2.
                { 6, new List<int> { 2 } } // Node 6 is connected to node 2.
            };

            // BFS starting from node 0
            Queue<int> queue = new Queue<int>(); // Initialize a queue to manage nodes to visit during BFS.
            HashSet<int> visited = new HashSet<int>(); // Initialize a set to track visited nodes and avoid revisits.

            queue.Enqueue(0); // Add the starting node (node 0) to the queue.
            visited.Add(0); // Mark the starting node as visited.

            Console.WriteLine("Breadth-First Search Order:");

            while (queue.Count > 0) // Loop until there are nodes in the queue.
            {
                int node = queue.Dequeue(); // Remove the next node from the front of the queue for processing.
                Console.WriteLine($"Visited node: {node}"); // Print the currently visited node.

                foreach (int neighbor in graph[node]) // Iterate through all neighbors of the current node.
                {
                    if (!visited.Contains(neighbor)) // Check if the neighbor node has not been visited yet.
                    {
                        Console.WriteLine($"Unvisited neighbor node: {neighbor}"); // Inform about the unvisited neighbor node.
                        queue.Enqueue(neighbor); // Add the neighbor node to the queue for future processing.
                        visited.Add(neighbor); // Mark the neighbor node as visited.
                    }
                }
            }
        }
    }
}
