using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Person
    {
        private static string name;

        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Person()
        {
            name = "Tom";
        }
    }

    class A : Person
    {
        private static string surname;

        public static string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public A()
        {
            surname = "Johnson";
        }
    }
    class B : A
    {
        private static int age;
        public static int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public B()
        {
            age = 17;
        }

        static public void Show()
        {
            Trace.WriteLine(Name);
            Trace.WriteLine(Surname);
            Trace.WriteLine(Age);
        }
    }
    class Program
    {
        static public void Main()
        {
            B b = new B();
            B.Show();
        }
    }
}
