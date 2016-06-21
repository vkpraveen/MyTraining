using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public void Main(string[] args)
        {
            diff sam = new diff();
            nest n = new nest();
            nest.inner ni = new nest.inner();
            ni.innermethod();
           
            Console.WriteLine(nest.inner.x);
            sam.sample();
           
        }
        class nest
        {
            public static int a = 20;
            public class inner{
                nest outero = new nest();
              public static int x = 10;
                public void innermethod()
                {
                    Console.WriteLine(a);
                }
            }
        }
        public class diff
        {
            public void sample()
            {
                Console.WriteLine("This is a sample class");
                Console.ReadLine();
            }
        }
    }
}
