using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthimatic_Operations
{
    class Program
    {
        public class Operations
        {
            public int add(int a, int b)
            {
                return a + b;
            }

            public double substract(double a, double b)
            {
                return a - b;
            }

            public double division(double a, double b)
            {
                return a/b;
            }

            public int modulo(int a, int b)
            {
                return a % b;
            }
        }
        static void Main(string[] args)
        {
            Operations Opratn= new Operations();
            int addition = Opratn.add(4, 5);
            Console.WriteLine("addition of {0} & {1} = {2}", 4,5, addition);

            double minus = Opratn.substract(39.89, 15.99);
            Console.WriteLine("Substraction of {0} & {1} = {2}", 39.89, 15.99, minus);
            

            double division = Opratn.division(39.89, 15.99);
            Console.WriteLine("Division of {0} & {1} = {2}", 39.89, 15.99, division);

            double modulo = Opratn.modulo(38, 3);
            Console.WriteLine("Modulos of {0} & {1} = {2}", 38, 3, modulo);
            Console.ReadKey();
        }
    }
}
