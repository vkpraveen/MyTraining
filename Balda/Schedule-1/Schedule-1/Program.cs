using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_1
{
    public class Worker
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public Worker(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public class NestedClass
        {
            public NestedClass()
            {
                Console.WriteLine("NESTED CLASS");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker obj1 = new Worker("Jonney", 12);
            Console.WriteLine("worker name1: {0}  age1: {1}", obj1.Name, obj1.Age);

            Worker obj2 = obj1;
            obj2.Name = "sony";
            obj2.Age = 13;
            Console.WriteLine("worker name2: {0}  age2: {1}", obj2.Name, obj2.Age);
            Console.WriteLine("worker name1: {0}  age1: {1}", obj1.Name, obj1.Age);
            Worker.NestedClass nc = new Worker.NestedClass();
            Console.ReadLine();

        }
    }
}
