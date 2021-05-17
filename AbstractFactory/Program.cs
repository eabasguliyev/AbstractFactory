using System;
using System.Reflection.Metadata.Ecma335;
using AbstractFactory.Asia;
using AbstractFactory.Australia;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IContinentFactory continentFactory = null;


            Console.WriteLine("1. Asia factory\n2. Australia factory");

            var selection = Console.ReadLine();


            if (selection == "1")
                continentFactory = new AsiaFactory();
            else if (selection == "2")
                continentFactory = new AustraliaFactory();


            ICarnivorous carnivorousAnimal = null;
            IHerbivorous herbivorousAnimal = null;

            try
            {
                carnivorousAnimal = continentFactory.CreateCarnivorous("Platypus");
                herbivorousAnimal = continentFactory.CreateHerbivorous("BlackSwan");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            carnivorousAnimal?.Hunt();
            carnivorousAnimal?.Eat();

            herbivorousAnimal?.Eat();
            herbivorousAnimal?.Sleep();
        }
    }
}
