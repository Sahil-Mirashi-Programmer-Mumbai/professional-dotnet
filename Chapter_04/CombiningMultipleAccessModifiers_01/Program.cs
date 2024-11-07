// Program to demonstrate Combining Multiple Access Modifiers in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace CombiningMultipleAccessModifiers_01
{
    class Document
    {
        // Accessible in derived class or within the same assembly
        protected internal string title;

        public Document(string docTitle)
        {
            title = docTitle;
        }

        // Accessible in derived class within the same assembly
        private protected void DiplayDocTitle()
        {
            Console.WriteLine($"Document Title: {title}");
        }
    }

    class Report : Document
    {
        public Report(string title) : base(title) { }

        public void DisplayReportTitle()
        {
            DiplayDocTitle();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Combining Multiple Access Modifiers in C# with Visual Studio\n");

            Report book = new Report("Daily Report");
            book.DisplayReportTitle(); // Output: Document Title: Daily Report
        }
    }
}
