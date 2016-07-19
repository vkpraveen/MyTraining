using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorhism
{
    class baseclass
    {
        public virtual void method1()
        {
            Console.WriteLine("base class method-1");
        }
        public virtual void method2()
        {
            Console.WriteLine("base class method-2");

        }
        public void method3()
        {
            Console.WriteLine("base class method-3");
        }
        public void method4(){
            Console.WriteLine("basebase method4");
        }
        public virtual void method5()
        {
            Console.WriteLine("base class virtual without override and new keyword");
        }
    }
    class derivedclass:baseclass
    {
        public override void method1()
        {
            Console.WriteLine("derived class method-1");
        }
        public new void method2()
        {
            Console.WriteLine("derived class method-2");
        }
        public void method3()
        {
            Console.WriteLine("Derived class method-3");
        }
        //public override void method4(){
        //    Console.WriteLine("derived class only override without virtual");
        //}
        public void method5(){
            Console.WriteLine("derived method 5");
        }
    }
//    public  abstractclass abs{
//    public void method4(){
//    Console.WriteLine("hi");
//}

//}
    class overrloading
    {
        public void m1(int a)
        {
            Console.WriteLine("value of integer a: {0}", a);
        }
        public void m1(int a, float b)
        {
            Console.WriteLine("value of interger and float is {0}, {1}", a, b);
        }
        public double m1( double a)
        {
            Console.WriteLine("value of double {0}", a);
            return a;
        }
    }

    class accessmodifier
    {
        protected int g = 12;
        protected int age=5;
        private int value = 3;
        public void mth1()
        {
            Console.WriteLine("private value:{0}", value);
            Console.WriteLine("protected value:{0}", age);
            Console.WriteLine("public example");
        }
        private void mth2()
        {
            Console.WriteLine("private example");
        }
        protected void mth3()
        {
            Console.WriteLine("protected example");
        }
        internal void mth4()
        {
            Console.WriteLine("internal example");
        }
        protected internal void mth5()
        {
            Console.WriteLine("protected internal example");
        }
            
             protected internal int mth6
        { 
 
            get {
                
            Console.WriteLine("protected internal example{0}:",age);
            return age;
           // Console.WriteLine("value is:{0}",age);
            }

        }
    }

    class protectedexample : accessmodifier
    {
        protectedexample()
    {
        Console.WriteLine("value g:{0}", g);
    }
    }

    //constructor default and parameter
    public class constructor
    {
        public int a = 10;
        private int b = 5;
        public constructor (){
            Console.WriteLine("value of a and b before:{0},{1}", a, b);
        Console.WriteLine("default constructor");
         a = 20;
         b = 10;
         Console.WriteLine("value of a and b after:{0},{1}", a, b);
    }
        public constructor(int x, int y) {
          //  Console.WriteLine("parameter constructor example before assigning value of a and b:{0}, {1}", a, b);
            int a = x;
            int b = y;
            Console.WriteLine("parameter constructor value of a and b:{0}, {1}", a, b);

    }
       ~constructor()
        {
            Console.WriteLine("Destructor is called");
        }


    }

    //destuctor
    public class destuctor
    {
        public destuctor()
        {
            Console.WriteLine("constuctor called");

        }
        ~destuctor()
        {
            Console.WriteLine("destructor called");
        }
    }
    public class sealex
    { public virtual void display(){
        Console.WriteLine("base class");
    }
    }
    public class seal1 : sealex
    {
        public override sealed void display()
        {
            Console.WriteLine("derived class");
        }
    }
    //public class seal2 : seal1
    //{
    //    public override void display()
    //    {
    //        Console.WriteLine("sealed called");
    //    }
    //}


    class Program
    {
        static void Main(string[] args)
        {
            baseclass bc = new baseclass();
            derivedclass dc = new derivedclass();
            baseclass bcdc = new derivedclass();
            bc.method1();
            bc.method2();
            bc.method3();
            dc.method1();
            dc.method2();
            dc.method3();
            bcdc.method1();
            bcdc.method2();
            bcdc.method3();
            
            bc.method4();
            dc.method4();
            bcdc.method4();

            bc.method5();
            dc.method5();
            bcdc.method5();

            //overloading
            overrloading ol = new overrloading();
            ol.m1(10);
            ol.m1(5,2);
            ol.m1(566666);


            //accessmodifier
            accessmodifier am = new accessmodifier();
            am.mth1();
            //am.mth2();
            //am.mth3();
            am.mth4();
            am.mth5();
            int s=am.mth6;
            Console.WriteLine("--protected internal--{0}", s);

           // protectedexample proex = new protectedexample();

            //constuctor
            constructor con = new constructor();
            con.a = 2;
           // con.b = 6;
           // Console.WriteLine("value of a,b: {0},{1}", con.a, con.b);
            Console.WriteLine("value of a: {0}", con.a);
            constructor cons = new constructor(30, 50);

            //destructor
            destuctor des = new destuctor();

            //sealed
            sealex seal = new sealex();
            seal.display();
           // seal2 se = new seal2();

            Console.ReadKey();
        }
    }
}
