using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program : Method
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write smth: ");
            ArgClass();

            Console.ReadLine();
        }
    }

    class Method
    {
        public static void ArgClass()
        {
            int n;
            double d;
            char c;
            bool b;
            int counterint = 0;
            string str = Console.ReadLine();
            if (str.Contains('.'))
            {
                str = str.Replace('.', ',');
            }
            bool resultn = int.TryParse(str, out n);
            if (resultn == true)
            {
                Trace.WriteLine("http://int: " + n);
                counterint += 1;
            }
            bool resultd = double.TryParse(str, out d);
            if (resultd == true && counterint == 0)
            {
                Trace.WriteLine("http://double: " + d);
            }
            bool resultc = char.TryParse(str, out c);
            if (resultc == true)
            {
                Trace.WriteLine("char: " + c);
            }
            bool resultb = bool.TryParse(str, out b);
            if (resultb == true)
            {
                Trace.WriteLine("bool: " + b);
            }
            else
            {
                Trace.WriteLine("string: " + str);
            }
        }
    }
}
