using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class calculator
    {
        public int add(int x, int y)
        {
            Console.WriteLine("x+y:{0}", x + y);
            x = 10; y = 5;
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
        public int mul(int x, int y)
        {
            return x * y;
        }
        public int div(int x, int y)
        {
            return x / y;
        }
        public int mod(int x, int y)
        {
            return x % y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            calculator cal = new calculator();
            int z = cal.add(10, 20);
            int p = cal.sub(20, 10);
            int q = cal.mul(20, 10);
            int r = cal.div(20, 10);
            int s = cal.mod(20, 10);
           
            Console.WriteLine("add:{0}",z);
            Console.WriteLine("sub:{0}",p);
            Console.WriteLine("mul:{0}",q);
            Console.WriteLine("div:{0}",r);
            Console.WriteLine("mod:{0}",s);
            Console.ReadLine();


        }
    }
}
