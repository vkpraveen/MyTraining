using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
interface interfaceSample
{
    void SampleInterface();
}
abstract class abs
{
    public abstract void calc();
}
class Program
{
    static void Main(string[] args)
    {
        interfaceSample i1 = new Implemntation();
        i1.SampleInterface();
        parent p = new parent();
        child c = new child();
        Console.WriteLine("calling from parent class");
        c.display();
        c.display1();
        Console.WriteLine("From parent class");
        p.display();
        def d = new def();
        sub s = new sub();
        d.calc();
        s.calc();
        Console.ReadLine();

    }
    class Implemntation : interfaceSample
    {
        public void SampleInterface()
        {
            Console.WriteLine("this is an interface ");

        }

    }
    public class parent
    {
        public void display()
        {
            Console.WriteLine("this is a parent class");

        }
    }
    class child : parent
    {
        public void display1()
        {
            Console.WriteLine("this is a child class");

        }

    }
    class def : abs
    {
        public override void calc()
        {

            Console.WriteLine("this is add method {0}");

        }

    }
    class sub : abs
    {
        public override void calc()
        {
            Console.WriteLine("this is sub method {0}");
            Console.ReadLine();
        }
    }
}


