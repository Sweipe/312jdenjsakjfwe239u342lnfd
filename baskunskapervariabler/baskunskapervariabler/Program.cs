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
            //var is a *(wildcard), assigns a valid datatype for given value
            var anything = 32;
            var secondthing = "hero orl";
            int num = 32;
            int sum = num + 1;
            string anyText = "hello word";
            float floatie = 1.234567f;
            char character = 'a';

            Sphere redball = new Sphere("red");
            var oddball = new Sphere("gray");

            redball.ShoutColor();
            oddball.ShoutColor();

            Console.Write("Comment: ");
            File.AppendAllText("something.txt", Console.ReadLine());

            if (!File.Exists("activation.txt")) {
                File.AppendAllText("activation.txt", DateTime.Now.ToString());
            }
        }
    }

}
