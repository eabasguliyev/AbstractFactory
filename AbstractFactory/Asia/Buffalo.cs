using System;

namespace AbstractFactory.Asia
{
    public class Buffalo:IHerbivorous
    {
        public string Name { get; set; }
        public void Sleep()
        {
            Console.WriteLine($"{Name} sleeping!");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} eating!");
        }

        public void Run()
        {
            Console.WriteLine($"{Name} running!");
        }

        public Buffalo()
        {
            Name = "Buffalo";
        }
    }
}