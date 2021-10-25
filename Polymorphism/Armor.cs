using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Armor
    {
        public string type = "generic";
        public Armor()
        {
            Report();
        }
        public virtual void Report() {
            Console.WriteLine("Armor");
        }
    }
    public class APC : Armor {
        //public string type = "APC";
        public override void Report() {
            Console.WriteLine("APC Armor");
            type = "apc";
        }
    }
    public class IFV : Armor {
        public override void Report()
        {
            Console.WriteLine("IFV Armor");
        }
    }

    public class Tank {
        public string type = "tank";
        public Tank() {
            Report();
        }
        public virtual void Report()
        {
            Console.WriteLine("Base tank");
        }
    }

    public class M1 : Tank {
        public string name = "M1";
        public override void Report()
        {
            Console.WriteLine("Sub tank");
        }
    }

    public class M1A2 : M1 {
        public string version = "A2";
        public override void Report()
        {
            Console.WriteLine("SubSub tank");
        }
    }
}
