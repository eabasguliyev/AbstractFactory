using System;

namespace AbstractFactory.Asia
{
    public class Tiger:ICarnivorous
    {
        public string Name { get; set; }
        public void Run()
        {
            Console.WriteLine($"{Name} running!");
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} hunting!");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} eating!");
        }

        public Tiger()
        {
            Name = "Tiger";
        }
    }
}