using System;

namespace AbstractFactory.Australia
{
    public class Platypus : ICarnivorous
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


        public Platypus()
        {
            Name = "Platypus";
        }
    }
}