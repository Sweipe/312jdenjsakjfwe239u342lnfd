using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramArv
{
    abstract class Vehicle
    {
        protected string name;
        protected float fuel = 0;
        protected float fuel_max;
        protected float usage;
        public Vehicle(string name, float fuel_max, float usage)
        {
            this.name = name;
            this.fuel_max = fuel_max;
            this.usage = usage;
        }

        public void RefillFrom(ref float storage) {
            Console.WriteLine("{0} has refueled!", name);
            float space = fuel_max - fuel;
            if (storage >= space)
            {
                fuel = fuel_max;
                storage -= space;
            } else {
                fuel += storage;
                storage = 0;
            }
        }
    }
}
