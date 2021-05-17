namespace AbstractFactory
{
    public interface ICarnivorous
    {
        string Name { get; set; }

        void Run();

        void Hunt();
        void Eat();
    }
}