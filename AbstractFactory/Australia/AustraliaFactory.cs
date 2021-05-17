using System;

namespace AbstractFactory.Australia
{
    public class AustraliaFactory:IContinentFactory
    {
        public ICarnivorous CreateCarnivorous(string animalName)
        {
            return animalName switch
            {
                "Platypus" => new Platypus(),
                _ => throw new ArgumentOutOfRangeException(nameof(animalName), "Animal not implemented"),
            };
        }

        public IHerbivorous CreateHerbivorous(string animalName)
        {
            return animalName switch
            {
                "BlackSwan" => new BlackSwan(),
                _ => throw new ArgumentOutOfRangeException(nameof(animalName), "Animal not implemented"),
            };
        }
    }
}