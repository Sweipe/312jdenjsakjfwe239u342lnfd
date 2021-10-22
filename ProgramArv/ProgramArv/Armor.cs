using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramArv
{
    class Armor : Vehicle
    {
        public Dictionary<string, int> operational_area;
        public Armor(string name, float fuelCapacity, float usage) : base(name, fuelCapacity, usage) {
            Console.WriteLine("{0} is ready for duty!", name);
        }

        public void AssignArea(Dictionary<string, int> area) {
            operational_area = area;
        }

        public void Patrol(string zone) {
            if (operational_area.TryGetValue(zone, out int distance))
            {
                if (fuel * usage / 2 < distance)
                {
                    Console.WriteLine("{0} is unable to patrol {1} due to lack of fuel.", name, zone);
                }
                else
                {
                    Console.WriteLine("{0} successfully patrolled {1}", name, zone);
                    fuel -= distance / (usage);
                }
            }
            else {
                Console.WriteLine("{0} requested to patrol {1} but the request was rejected.", name, zone);
            }
        }
    }
}
