using System;

namespace ModifiersCSharp
{
    class Parent
    {
        public string name;                 //public: Kan anropas utanför klassen
        protected string type = "human";    //protected: Kan anropas i sin klass eller i en subklass
        private int money = 50000;          //private: Kan bara anropas i sin klass

        public Parent(string name)
        {
            this.name = name;
        }
    }

    class Child : Parent
    {
        public Child(string name) : base(name)
        {}
        public void SayName() {
            Console.WriteLine(name);    //Anropar offentlig klass funkar bra
        }
        public void SayType() {
            Console.WriteLine(type);    //Anropar skyddad klass funkar bra
        }
        public void SayMoney() {
            Console.WriteLine(money);   //Denna subklass försöker anropa en privat variabel från sin superklass, alltså (en annan klass), vilket inte går
        }
    }
}