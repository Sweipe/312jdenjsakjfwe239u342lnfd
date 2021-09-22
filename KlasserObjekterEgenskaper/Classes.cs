using System;

public class Star
{
    public string name;
    public Star(string x)
    {
        name = x;
    }

    public void Present()
    {
        Console.WriteLine("My name is {0}!", name);
    }

    public void Explosion()
    {
        Console.WriteLine("Booom!");
    }
}

public class Light
{
    public int str;
    public Light(int x)
    {
        str = x > 10 ? 10 : x;
    }

    public void Shine()
    {
        if(str<1)
        {
            Console.WriteLine("I am cold.");
        } else if(str<5)
        {
            Console.WriteLine("I light.");
        } else if(str<6)
        {
            Console.WriteLine("I am strong.");
        } else
        {
            Console.WriteLine("I Shineeeeee!");
        }
    }

    public void PutOut()
    {
        str = 0;
        Console.WriteLine("My light has been put out.");
    }
    
}

public class Nature
{
    public static void PresentStar(Star star)
    {
        Console.WriteLine("This star is called {0}", star.name);
    }

    public static void ObserveLight(Light light)
    {
        if (light.str < 1)
        {
            Console.WriteLine("The light is weak.");
        }
        else if (light.str < 5)
        {
            Console.WriteLine("The light is emitting a little light.");
        }
        else if (light.str < 6)
        {
            Console.WriteLine("The light lightens the area.");
        }
        else
        {
            Console.WriteLine("The light is so bright that I cannot observe it");
        }
    }
}