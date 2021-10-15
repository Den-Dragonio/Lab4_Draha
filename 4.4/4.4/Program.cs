using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    class Key : ApplicationLicense
    {
        private static readonly Random rnd = new Random();
        private static readonly Random random = new Random();
        private static readonly string alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static void Generate()
        {
            var key = new char[25];
            for (int i = 1; i < key.Length; i++)
            {
                if (i % 5 == 0)
                {
                    key[i] = '-';
                }
                else
                {
                    key[i] = Key.alphabet[random.Next(alphabet.Length)];
                }
            }
            string password = new string(key);
            Console.WriteLine("Your key is:" + password);
        }

        public static void Get()
        {
            int a = rnd.Next(0, 2);
            if( a == 0)
            {
                Console.WriteLine("Sadly, but there is no key left fot u(");
            }
            else if (a == 1)
            {
                Console.Write("Congrats! ");
                Generate();
            }
        }
    }

    class ApplicationLicense 
    {
        public static void AllowTrial()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Don`t worry! You still get the trial version)");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void AllowCommon()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success! You get the COMMON version!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void AllowPro()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Success! You get the PRO version!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class Program : Key 
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ApplicationLicense al = new ApplicationLicense();
                Get();
                Console.WriteLine("Type your key here (if u own one): ");
                var str = Console.ReadLine();
                int count = 0;
                var checkOne = new List<string>()
                {
                    "1","2","3","4","5","6","8","9","B","C","F","J","K","L","M","N","O","P","Q","S","T","U","V","W","X","Z","Y","R","A","G","H"
                };
                var checkTwo = new List<string>()
                {
                    "7","D","E","N","I","S",
                };
                var checkThree = new List<string>()
                {
                    ""," "
                };
                foreach (var checkthree in checkThree)
                {
                    if (str.Contains(checkthree))
                    {
                        count -= 1;
                    }
                }
                foreach (var checktwo in checkTwo)
                {
                    if (str.Contains(checktwo))
                    {
                        count += 1;
                    }
                }
                foreach (var checkone in checkOne)
                {
                    if (str.Contains(checkone))
                    {
                        count += 0;
                    }
                }

                if (count > 0)
                {
                    AllowPro();
                }
                else if (count == 0)
                {
                    AllowCommon();
                }
                else if (count < 0)
                {
                    AllowTrial();
                }

                Console.ReadKey();
            }
        }

    }
}
