namespace AbstractFactory
{
    public interface IContinentFactory
    {
        ICarnivorous CreateCarnivorous(string animalName);
        IHerbivorous CreateHerbivorous(string animalName);
    }
}