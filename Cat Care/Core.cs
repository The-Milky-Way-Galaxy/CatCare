namespace CatCare;
class Core
{
    static void Main()
    {
        Cat PlayerCat = new Cat("Sally");
        void Update()
        {
            PlayerCat.Display();
            Console.WriteLine("lol");
        }

        Update();
        Console.ReadKey();
    }
}