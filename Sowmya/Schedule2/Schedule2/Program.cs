using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = new DateTime(2016, 6, 22);
            calc o = new calc();
            property p = new property();
            p.Test = 123;
             calc.operation();
            Console.WriteLine("Today:{0}", DateTime.Today);
            Console.WriteLine("Date:{0}", today);
            Console.WriteLine("Property value:" + p.Test);
            Console.ReadLine();

        }
        class calc
        {
            public static void operation()
            {
                int sum, sub, mod, div, a, b;
                float mul1;
                double mul2;
                decimal res;
                string name = "Training";
                //DateTime date = new DateTime(2016, 22, 6);
                Console.WriteLine("enter int values");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("enter float values");
                mul1 = float.Parse(Console.ReadLine());
                mul2 = double.Parse(Console.ReadLine());
                sum = a + b;
                sub = a - b;
                div = a / b;
                mod = a % b;
                res = Convert.ToDecimal(mul1 * mul2);
                Console.WriteLine("Addition of 2 int numbers is {2}", a, b, sum);
                Console.WriteLine("Subraction of 2 int numbers is {2}", a, b, sub);
                Console.WriteLine("Division of 2 int numbers is {2}", a, b, div);
                Console.WriteLine("Modulus of 2 int numbers is {2}", a, b, mod);
                Console.WriteLine("Multiplication of a float and double value and result is decimal valie is{2}", mul1, mul2, res);
                Console.WriteLine(name);

            }
        }
        class property
        {
            private int test;
            public int Test
            {
                get { return test; }
                set { test = value; }
            }
        }

    }

}


