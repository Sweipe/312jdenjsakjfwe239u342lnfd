using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserObjekterEgenskaper
{
    class Program
    {
        static void Main(string[] args)
        {
            Star star = new Star("Mark");
            Light light = new Light(12);

            Nature.PresentStar(star);
            star.Present();
            star.Explosion();

            Nature.ObserveLight(light);
            light.Shine();
            light.PutOut();
            Nature.ObserveLight(light);
            light.Shine();




            Console.ReadKey();
        }
    }
}
