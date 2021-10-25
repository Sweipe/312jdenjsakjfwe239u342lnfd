using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Armor armor = new Armor();
            Armor apc = new APC();
            Console.WriteLine(apc.type);
            Armor ifv = new IFV();

            Console.WriteLine();//Separator

            Tank tank = new Tank();
            Tank m1 = new M1();
            Tank m1a2 = new M1A2();

            Console.ReadKey();
        }
    }
}
