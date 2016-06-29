using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ 
    public class Parent{
        public void Length( int length)
        {
             length=10;
        }
        public void Breadth(int breadth)
        {
            breadth= 5;

        }
        protected int length = 10;
        protected int breadth = 10;
        protected int width = 10;

    }
    public interface getWidth{
        int getCost(int cost);
     
    }
    public class Child : Parent, getWidth
    {
        public int area()
        {
            return (length*breadth);
        }
        public int getCost(int cost)
        {
            
            return cost * 70;
        }
    }
    interface Hello
    {
        void ahello();
    }
    class Hi : Hello
    {
        public void ahello()
        {
            Console.WriteLine("hello");
        }
        public int ahi( int a)
        {
            Console.WriteLine("hi");
            return a;
        }
    }
    //interfaces
    interface IOne
    {
        void ONE();
    }
    interface ITwo
    {
        void TWO();
    }
    interface IThree : IOne
    {
        void THREE();
    }
    interface IFour
    {
        void FOUR();
    }
    interface IFive : IThree
    {
        void FIVE();
    }
    interface IEVEN : ITwo, IFour
    {
    }
    class ODDEVEN : IEVEN, IFive
    {
        public void ONE()
        {
            Console.WriteLine("This is ONE");
        }
        public void TWO()
        {
            Console.WriteLine("This is TWO");
        }
        public void THREE()
        {
            Console.WriteLine("This is THERE");
        }
        public void FOUR()
        {
            Console.WriteLine("This is FOUR");
        }
        public void FIVE()
        {
            Console.WriteLine("This is FIVE");
        }
    }

    //end

    //abstract
    abstract class calculator
    {

        public int add(int x, int y)
        {
            Console.WriteLine("hello");
            return x + y;
        }
        public abstract int mul(int x, int y);
    }

    class calculator1 : calculator
    {
        public int div(int x, int y)
        {
            return x / y;
        }
        public override int mul(int x, int y)
        {
            return x * y;
        }
    }

//end
    class Program
    {
        static void Main(string[] args)
        {
            int cost=10;
            Child c = new Child();
            Console.WriteLine("Area: {0}", c.area());
            Console.WriteLine("Area: {0}", c.getCost(cost));
            //interface
            Console.WriteLine("This is ODD");
            IFive obj1 = new ODDEVEN();
            obj1.ONE();
            obj1.THREE();
            obj1.FIVE();
            Console.WriteLine("\n\nThis is EVEN");
            IEVEN obj2 = new ODDEVEN();
            obj2.TWO();
            obj2.FOUR();

            //end
            
            Hi greet = new Hi();
            int b=greet.ahi(2);
            greet.ahello();
            Console.WriteLine("value={0}", b);
            //abstarct
            calculator1 cal = new calculator1();
            int added = cal.add(10, 10);
            int multiple = cal.mul(5, 4);
            int div = cal.div(10, 5);
            Console.WriteLine("add=10+10={0}, mul=5*4={1}, div=10/5={2}", added, multiple,div);

            //end
            Console.ReadLine();
        }
        
    }
}
