/*
Program to demonstrate LINQ to XML in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ to XML simplifies querying and parsing XML documents.
Application: Extracting structured data from XML files or APIs.
*/

using System.Xml.Linq;

namespace LINQToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ to XML in C# with Visual Studio\n");

            // Sample XML data
            string xmlData = @"
                <Employees>
                    <Employee Name='Alice' Age='20' />
                    <Employee Name='Bob' Age='22' />
                </Employees>";

            // Parsing XML using LINQ
            XDocument doc = XDocument.Parse(xmlData);
            var studentNames = from student in doc.Descendants("Employee")
                               select student.Attribute("Name").Value;

            // Displaying student names
            Console.WriteLine("Students from XML:");
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}