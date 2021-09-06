using System;

class Sphere
{
    //The variables of this class, all 'Sphere' objects will have these
    public int radius = 5;
    public string color = "none";
    public Sphere(string Color) //the 'Sphere' object will be declared with a string argument
    {
        color = Color;
    }

    //This down here is a method
    public void ShoutColor()
    {
        Console.WriteLine("My color is {0}", color);
    }
}