// Program to demonstrate Undo Redo Functionality using Two Stacks in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Demonstrates undo/redo functionality using two stacks.
    Shows how stacks can maintain a history of operations for easy undo/redo.
    Useful in text editors, graphic design tools, etc.
*/

namespace _09_UndoRedoFunctionalityUsingTwoStacks
{
    internal class Program
    {
        static Stack<string> undoStack = new Stack<string>();
        static Stack<string> redoStack = new Stack<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Undo Redo Functionality using Two Stacks in C# with Visual Studio\n");

            PerformAction("Action 1");
            PerformAction("Action 2");
            PerformAction("Action 3");

            Console.WriteLine("\nUndo last action:");
            Undo();

            Console.WriteLine("\nRedo last action:");
            Redo();
        }

        static void PerformAction(string action)
        {
            Console.WriteLine($"Performing: {action}");
            undoStack.Push(action); // Save action to undo stack
            redoStack.Clear(); // Clear the redo stack since a new action invalidates future redos
        }

        static void Undo()
        {
            if (undoStack.Count > 0)
            {
                string action = undoStack.Pop();
                Console.WriteLine($"Undoing: {action}");
                redoStack.Push(action); // Move the action to redo stack
            }
            else
            {
                Console.WriteLine("No actions to undo.");
            }
        }

        static void Redo()
        {
            if (redoStack.Count > 0)
            {
                string action = redoStack.Pop();
                Console.WriteLine($"Redoing: {action}");
                undoStack.Push(action); // Move the action back to undo stack
            }
            else
            {
                Console.WriteLine("No actions to redo.");
            }
        }
    }
}