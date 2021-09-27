using System;

public class MasterClass
{
    public string pu = "Public.";
    protected string pro = "Protected.";
    private string pri = "Private.";

    public void Publico()
    {
        Console.WriteLine(pu);
    }
    public void Protecto()
    {
        Console.WriteLine(pro);
    }
    public void Privato()
    {
        Console.WriteLine(pri);
    }

}

public class ChildClass : MasterClass
{
    public void NewPublico()
    {
        Console.WriteLine(pu);
    }
    public void NewProtecto()
    {
        Console.WriteLine(pro);
    }
}
