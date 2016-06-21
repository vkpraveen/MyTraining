using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 42;
            string greeting = "Hello, World!";
            double bigNumber = 1e100;

            bool content = true;
            bool noContent = false;

            int[] myInts = { 5, 10, 15 };
            sbyte age;
            float f = 10; 
            byte z = 22;
            char x = 'x';

            decimal a = 0.999m;
            decimal b = 9999999999999999999999999999m;

            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.UtcNow;
            DateTime date3 = DateTime.Today;

                
            Console.WriteLine("{0} {1} {2}", answer, greeting, bigNumber);
            Console.WriteLine("{0} {1} {2}", f, z,x);
            Console.WriteLine("this is true example", content);
            Console.WriteLine("this is false example {0}.", noContent);
            Console.WriteLine("myInts[0]: {0}, myInts[1]: {1}, myInts[2]: {2}", myInts[0], myInts[1], myInts[2]);
            Console.WriteLine("{0} {1} {2}", date1, date2, date3);

            Console.WriteLine("My amount = {0:C}", a);
            Console.WriteLine("Your amount = {0:C}", b);


            Console.WriteLine("Enter your age\n");
            age = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("Age = {0}", age);

            Console.WriteLine("{0} {1} {2}", date1, date2, date3);



            Console.WriteLine("int size:{0}", sizeof(int));
            Console.WriteLine("float size:{0}", sizeof(float));
            Console.WriteLine("char size:{0}", sizeof(char));
            Console.WriteLine("bool size:{0}", sizeof(bool));
            Console.WriteLine("decimal size:{0}", sizeof(decimal));
            Console.WriteLine("double size:{0}", sizeof(double));
            Console.WriteLine("byte size:{0}", sizeof(byte));
            Console.WriteLine("sbyte size:{0}", sizeof(sbyte));
            Console.WriteLine("long size:{0}", sizeof(long));
            Console.WriteLine("ulong size:{0}", sizeof(ulong));
            Console.WriteLine("short size:{0}", sizeof(short));


            Console.ReadLine();
        }
    }
}
