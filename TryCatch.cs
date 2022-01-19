using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Secure();
            Insecure();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            void Secure()
            {
                try
                {
                    Console.Write("(Säker)  Skriv in ett tal som talet 10 kan divideras med:");
                    int num = 10/int.Parse(Console.ReadLine());
                    Console.WriteLine($"Felfritt, resultatet blev {num}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ett fel uppstod med ditt tal");
                }
            }

            void Insecure()
            {
                Console.Write("(Osäker) Skriv in ett tal som talet 10 kan divideras med:");
                int num = 10/int.Parse(Console.ReadLine());
                Console.WriteLine($"Felfritt, resultatet blev {num}");
            }
        }
    }
}
