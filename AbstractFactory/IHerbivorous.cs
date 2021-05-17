namespace AbstractFactory
{
    public interface IHerbivorous
    {
        string Name { get; set; }

        void Sleep();
        void Eat();
        void Run();
    }
}