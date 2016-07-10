using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class A
    {
       
        public int x;
        public int y;
        public int z;
        
        //Parameterized constructor
        public A() { }

        public A(int x)
        {
            this.x =x;
        }
        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public A(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }
       
    }

    public class X : A //accessing base class constructor with 2 parameters
    {
        public int c;
        public X(int a, int b) : base(a, b)
        {
             c = x + y;
        }
    }

    public class B
    {
        public string name;
        public int age;
        //default constructor
        public B()
        {
            
        }
       
    }

    public class c
    {
        public bool IsInitialized;
        private c ()
        {
            IsInitialized = true;
        }
    }

    //public class P
    //{
    //    static readonly long baseline;

    //    static P()
    //    {
    //        baseline = DateTime.Now.Ticks;
    //        Console.WriteLine(baseline);
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //Parameterized constructor
            A p1 = new A(2);
            Console.WriteLine("Single parameter, value of X ={0}", p1.x, p1.y, p1.z);

            A obj = new A(5,6);
            Console.WriteLine("Double parameter, value of X= {0} & Y= {1}", obj.x,obj.y);

            A p3 = new A(14,15,16);
            Console.WriteLine("Three parameter, value of X= {0} & Y= {1} & Z = {2}" , p3.x, p3.y,p3.z);

            //accessing base class constructor from derived class
            X result = new X(10,20);
            Console.WriteLine("addition of {0} + {1} ={2}",result.x, result.y, result.c);

            //default constructor
            B person = new B();
            Console.WriteLine("default constructor values of X= {0} & Y= {1}", person.name, person.age);
            Console.ReadLine();

            //Private constructor
            //c init = new c(); // cannot instanciate private members.

            //static constructor
            //P statCont = new P();
            
        }
    }
}
