using System;

namespace AbstractFactory.Australia
{
    public class BlackSwan : IHerbivorous
    {
        public string Name { get; set; }
        public void Sleep()
        {
            Console.WriteLine($"{Name} sleeping!");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} sleeping!");
        }

        public void Run()
        {
            Console.WriteLine($"{Name} sleeping!");
        }

        public BlackSwan()
        {
            Name = "Black Swan";
        }
    }
}