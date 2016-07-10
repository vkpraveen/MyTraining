using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Opp
    {
        public int a;
        public int b;
        public virtual void operation(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("value of A={0} & B={1}",a,b);
            
        } 
    }

    class Add: Opp
    {
        public override void operation(int a, int b)
        {
            base.operation(a,b);
            Console.WriteLine("Addition");
            int c = a + b;
            Console.WriteLine("{0} + {1} = {2}\n", a, b, c);
            
        }
    }

    class Sub : Opp
    {
        public override void operation(int a, int b)
        {
            base.operation(a,b);
            Console.WriteLine("Substraction");
            int c= a - b;
            Console.WriteLine("{0} - {1} ={2}\n", a,b,c);
            
        }
    }

    class Mul : Opp
    {
        public sealed override void operation(int a, int b)
        {
            base.operation(a, b);
            Console.WriteLine("Mulitplication");
            int c = a * b;
            Console.WriteLine("{0} * {1} ={2}\n", a, b, c);

        }
    }

    //inheriting sealed class, uncomment this code u will get error.
    //class X : Mul
    //{
    //    public override void operation(int a, int b) // cannot override inherited method bcoz its sealed.
    //    {
    //        base.operation(a, b);
    //        Console.WriteLine("division");
    //        int c = a / b ;
    //        Console.WriteLine("{0} / {1} ={2} ", a, b, c);
    //    }
    //}

    //access modiferes
    class AccessModifiers
    {
        public int pub;
        private int priv;
        protected int pro;
        internal int inter;

        public void method()
        {
            pro = 3;
            priv = 1;
            pub = 9;
            inter = 10;
            Console.WriteLine("In base class so access to private = {0}  & Protected ={1} & internal ={2} & public ={3}\n",priv,pro,inter, pub);
        }

    }

    class protectted : AccessModifiers
    {
        
         public void method()
         {
             pro = 3;
             inter = 1;
             pub = 2;
          //  Console.WriteLine("{0},{1}",priv,pro);  // in accessable due to protection level since private member 
             Console.WriteLine("In derived class so only protected ={0} & internal ={1} & public ={2}\n", pro, inter, pub);
         }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Opp add = new Add();
            add.operation(1, 5);

            Opp sub = new Sub();
            sub.operation(3, 2);

            Opp mul = new Mul();
            mul.operation(3, 2);

            //Mul tripMul = new X();
            //tripMul.operation(3, 6); // cannot override inherited method bcoz its sealed.

            //access modifier
            AccessModifiers acc = new AccessModifiers();
            acc.pub = 2;
          //acc.priv = 3; //inaccessable due to protection level
          //acc.pro = 4; //inaccessable due to protection level
            acc.inter = 5;

            acc.method();

            protectted derivved = new protectted();
            derivved.method();

            Console.WriteLine("accessable members from other classes are public = {0} & internal ={1}\n", acc.pub, acc.inter);

            Console.ReadLine();
        }
    }
}
