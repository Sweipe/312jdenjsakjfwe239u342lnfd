using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace baskunskapervariabler
{
    class Program
    {
        static void Main(string[] args)
        {
            //A few variables
            var anything = 32;
            var secondthing = "hero orl";
            int num = 32;
            int sum = num + 1;
            string anyText = "hello word";
            float floatie = 1.234567f;
            char character = 'a';

            //Declaring objects will class 'Sphere' and their unique string arguments
            Sphere redball = new Sphere("red");
            var oddball = new Sphere("gray");

            //calling method from the class 'Sphere'
            redball.ShoutColor();
            oddball.ShoutColor();

            //this will store user input in a file called 'something.txt'
            Console.Write("Comment: ");
            File.AppendAllText("something.txt", Console.ReadLine() + "\n");

            //this checks for file named 'activation.txt'
            //Registers first time the program is executed
            if (!File.Exists("activation.txt")) {
                File.AppendAllText("activation.txt", DateTime.Now.ToString());
            }
        }
    }

}
