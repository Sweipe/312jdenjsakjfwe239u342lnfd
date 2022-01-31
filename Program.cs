using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace TryCatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string text in args) { Console.WriteLine(text); }
            string input = string.Empty;
            Dictionary<string, string[]> groups = new Dictionary<string, string[]>()
            {
                { "Admin", new string[2] {"Juni280","RiteL"} },
            };
            bool safe = false;

            Console.WriteLine("Application is open and accepting commands,\ntype 'help' to summon list of commands.");
            while (true) {
                Console.Write("$");
                input = Console.ReadLine();
                if (input == "help") {
                    Console.WriteLine("'makearray'");
                    Console.WriteLine("'safe'");
                    Console.WriteLine("'unsafe'");
                    Console.WriteLine("'restart'");
                    Console.WriteLine("'makegroup'");
                    Console.WriteLine("'showgroup'");
                }
                if (input == "safe") { safe = true; }
                if (input == "unsafe") { safe = false; }
                if (input == "makearray") {
                    if (!safe)
                    {
                        CreateArray();
                    }
                    else {
                        try {
                            CreateArray();
                        } catch (Exception e) {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                if (input == "restart") {
                    var fileName = Assembly.GetExecutingAssembly().Location;
                    System.Diagnostics.Process.Start(fileName);
                    Environment.Exit(0);
                }
                if (input == "makegroup") {
                    if (!safe)
                    {
                        CreateGroup();
                    }
                    else
                    {
                        try
                        {
                            CreateGroup();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                if (input == "showgroup")
                {
                    if (!safe)
                    {
                        ReadGroup();
                    }
                    else
                    {
                        try
                        {
                            ReadGroup();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }

            void CreateArray() {
                
                Console.WriteLine("Creating an int array...\nNumber of elements: ");
                var num = int.Parse(Console.ReadLine());
                int[] list = new int[num];
                for (int i = 0; i < num; i++)
                {
                    Console.Write($"Element {i+1}: ");
                    list[i] = int.Parse(Console.ReadLine());
                }
                string previewArray = string.Empty;
                for (int i = 0; i < list.Length; i++) {
                    previewArray += list[i].ToString();
                    if (i + 1 < list.Length) {
                        previewArray += ",";
                    }
                }
                Console.WriteLine($"[{previewArray}] has been added to memory.");
            }

            void CreateGroup() {
                Console.WriteLine("Creating group... ");
                Console.WriteLine("Name of group: ");
                string name = Console.ReadLine();
                Console.WriteLine("Number of members: ");
                int amount = int.Parse(Console.ReadLine());
                string[] group = new string[amount];
                for (int i = 0; i < amount; i++) {
                    Console.WriteLine($"{i + 1} of {amount}, name: ");
                    group[i] = Console.ReadLine();
                }
                groups.Add(name, group);
            }

            void ReadGroup() {
                Console.WriteLine("Seek group by name:");
                string name = Console.ReadLine();
                foreach(string member in groups[name]) {
                    Console.WriteLine(member);
                }
            }
        }
    }
}
