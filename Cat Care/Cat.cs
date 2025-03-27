namespace CatCare;
class Cat
{
    Random RandomGen = new Random();
    int RandomResult;
    float Hunger = 0;
    float Boredom;
    bool Sick = false;
    string Name;
    string Personality;
    string Eyes = "oo";
    
    public Cat(string Name)
    {
        this.Name = Name;
        RandomResult = RandomGen.Next(0, 99);

        
        //personality roll
        if(RandomResult < 30)
        {
            Personality = "grumpy";
        }
        else if(RandomResult > 29 && RandomResult < 80)
        {
            Personality = "playful";
        }
        else if(RandomResult > 79)
        {
            Personality = "ravenous";
        }
    }

    public void Display()
    {
        Console.WriteLine("                   _ |\\_");
        Console.WriteLine("                   \\` "+Eyes+"\\");
        Console.WriteLine("              __,.-' =_T_=");
        Console.WriteLine("            .'        )");
        Console.WriteLine("      _    /   ,    \\/\\_");
        Console.WriteLine("     ((____|    )_-\\ \\_-`");
        Console.WriteLine("     `-----'`-----` `--`");

        Console.WriteLine(Name+" your "+Personality+" cat, is satiated!");
    }
}