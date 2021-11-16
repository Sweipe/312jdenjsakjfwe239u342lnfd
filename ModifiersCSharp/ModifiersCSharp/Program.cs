using System;

namespace ModifiersCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Child childObj = new Child("Victor");
            Console.WriteLine(childObj.name);       //Anropning av offentlig fält utanför sin klass funkar bra
            Console.WriteLine(childObj.type);       //Anropning av skyddad fält utanför sin klass stöter på problem
            Console.WriteLine(childObj.money);      //Anropning av privat fält utanför sin klass stöter på problem

            //Funktioner som offentlig-gör skyddade och private fält/variabler för att kringgå modifieraren.
            childObj.SayName();
            childObj.SayType();
            childObj.SayMoney();

            Console.ReadKey();
        }
    }
}
