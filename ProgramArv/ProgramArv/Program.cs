using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramArv
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> operational_area = new Dictionary<string, int>() {
                { "Echo", 2300 },
                { "Foxtrot", 16750 },
                { "Golf", 8760 },
            };
            float base_reserves = 5000;

            Armor apc = new Armor("APC01", 60, 835);
            apc.AssignArea(operational_area);
            apc.Patrol("Romeo");
            apc.Patrol("Echo");
            apc.RefillFrom(ref base_reserves);
            apc.Patrol("Echo");
            apc.Patrol("Foxtrot");
            apc.Patrol("Golf");

            Console.ReadKey();
        }
    }
}
