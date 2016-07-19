using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class calculator
    {
        private int x=8;
        private int y=8;
        private string name="hieee";
        private int age = 12;
        
        public int add
        {
            get {
                 return x + y;
            }
            set{
                x = 10;
                y = 5;
            }            
        }
        public string Name{
            get {
                Console.WriteLine(name);
                return name;
            }
            set {
                Console.WriteLine(name);
                name="hello";
            }
        }
        public int Age
        {
            get
            {
                Console.WriteLine(age);
                return age;
            }
            set
            {
                Console.WriteLine(age);
                age = 14;
            }
        }
        public override string ToString()
        {
            Console.WriteLine("override");
            return "Age = " + Age;
        }
 
    }

    class Program
    {
        static void Main(string[] args)
        {
            calculator obj = new calculator();
            obj.Name = "hai";
           // obj.add = 12;
            int p = obj.add;
            string q= obj.Name;
            int s = obj.Age;
            Console.WriteLine("x+y:{0}", p);
            Console.WriteLine("Name:{0}",q);
            Console.WriteLine("Age:{0}", s);
            Console.ReadLine();
        }
    }
}
