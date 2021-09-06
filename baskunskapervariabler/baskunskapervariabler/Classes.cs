using System;

class Sphere
{
    public int radius = 5;
    public string color = "none";
    public Sphere(string Color)
    {
        color = Color;
    }

    public void ShoutColor()
    {
        Console.WriteLine("My color is {0}", color);
    }
}