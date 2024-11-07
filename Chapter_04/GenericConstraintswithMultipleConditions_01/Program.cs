// Program to demonstrate Generic Constraints with Multiple Conditions in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace GenericConstraintswithMultipleConditions_01
{
    // Interface to ensure each type has an ID
    interface IEntity
    {
        int Id { get; }
    }

    // Entity class implementing IEntity interface
    class Person : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    // Interface to represent a repository
    interface IRepository<T> where T : IEntity, new()
    {
        T CreateEntity();
    }

    // EntityRepository class implementing IRepository interface
    class EntityRepository<T> : IRepository<T> where T : IEntity, new()
    {
        public T CreateEntity()
        {
            return new T();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Generic Constraints with Multiple Conditions in C# with Visual Studio\n");

            IRepository<Person> entity = new EntityRepository<Person>();
            Person person = entity.CreateEntity();
            Console.WriteLine("New entity created");
        }
    }

}
