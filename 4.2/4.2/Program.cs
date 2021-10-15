using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            string info;

            B1 b1 = new B1();
            B2 b2 = new B2();

            info = B1.str1;
            A A1 = new A(info);
            A.Display();
            info = B2.str2;
            A A2 = new A(info);
            A.Display();
        }
    }

    public class B
    {
        protected static string str;
        public static void Show()
        {
            Console.WriteLine("Write smth: ");
            str = Console.ReadLine();
        }
    }

    public class B1 : B
    {
        public static string str1;
        public B1()
        {
            Show();
            str1 = str;
        }
    }

    public class B2 : B
    {
        public static string str2;
        public B2()
        {
            Show();
            str2 = str;
        }
    }

    class A
    {
        public A(string info)
        {
            Input = info;
        }

        public static int n;
        public static char c;
        public static bool b, IsTrue;
        public static double d;
        public static string str;
        private static string input;

        public static int count = 0;

        public static string Input
        {
            get
            {
                return input;
            }
            set
            {
                str = value;

                IsTrue = int.TryParse(str, out n);
                if (IsTrue == true)
                {
                    Trace.WriteLine("int: " + value);
                }
                IsTrue = double.TryParse(str, out d);
                if (IsTrue == true)
                {
                    Trace.WriteLine("double: " + value);
                }
                IsTrue = char.TryParse(str, out c);
                if (IsTrue == true)
                {
                    Trace.WriteLine("char: " + value);
                }
                IsTrue = bool.TryParse(str, out b);
                if (IsTrue == true)
                {
                    Trace.WriteLine("bool: " + value);
                }
                if (count == 0)
                {
                    Trace.WriteLine("string: " + value);
                }
                input = "-- public";
            }

        }
        public static void Display()
        {
            Trace.WriteLine(input);
        }
    }
}
