using System;

namespace AbstractFactory.Asia
{
    public class AsiaFactory:IContinentFactory
    {
        public ICarnivorous CreateCarnivorous(string animalName)
        {
            return animalName switch
            {
                "Tiger" => new Tiger(),
                "Cobra" => new Cobra(),
                _ => throw new ArgumentOutOfRangeException(nameof(animalName), "animal not implemented"),
            };
        }

        public IHerbivorous CreateHerbivorous(string animalName)
        {
            return animalName switch
            {
                "Panda" => new Panda(),
                "Buffalo" => new Buffalo(),
                _ => throw new ArgumentOutOfRangeException(nameof(animalName), "animal not implemented"),
            };
        }
    }
}