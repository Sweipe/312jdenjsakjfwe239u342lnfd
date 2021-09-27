using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopesAndModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterClass myObj = new MasterClass();
            myObj.Publico();
            myObj.Protecto();
            myObj.Privato();
            Console.WriteLine();

            ChildClass childObj = new ChildClass();
            childObj.NewPublico();
            childObj.NewProtecto();

            Console.ReadKey();


        }
    }
}
