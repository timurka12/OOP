using System;

namespace ConsoleApplication1
{
    abstract class Person
    {
        abstract public void Live();
    }

    class worker : Person
    {
        public String nameofcompany { get; set; }
        public override void Live()
        {
            Console.WriteLine("worker work in " + nameofcompany);
        }
    }

    class philanthropist : Person
    {
        public String fonds { get; set; }
        override public void Live()
        {
            Console.WriteLine("philanthropist help " + fonds);
        }
    }

    class business : Person
    {
        public string restaurant { get; set; }
        override public void Live()
        {
            Console.WriteLine("He has a business - " + restaurant);
        }


        class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}