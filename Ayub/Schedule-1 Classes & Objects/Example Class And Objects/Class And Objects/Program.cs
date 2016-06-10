using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Objects
{
    class Program
    {
        public class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }

            //constructor 
            public Vehicle (string make, string model)
            {
                Make = make;
                Model = model;
            }

            public Vehicle()
            {
            }
        }
        static void Main(string[] args)
        {
            Vehicle objBMW = new Vehicle("BMW","E-series");
            Console.WriteLine("Vehicle1 Make ={0} Model ={1} ", objBMW.Make, objBMW.Model);


            Vehicle objAudi = new Vehicle();

            objAudi.Make = "Audi";
            objAudi.Model = "A-class";

            Console.WriteLine("Vehicle2 Make = {0} Model = {1}", objAudi.Make, objAudi.Model);

            // refering new object to an existing object.

            Vehicle objMaruti = objBMW;

            objMaruti.Make = "Maruti Suzuki";
            objMaruti.Model = "800";
            Console.WriteLine("Vehicle3 Make = {0}, Model = {1}", objMaruti.Make, objMaruti.Model);

            //changing the objBMW values as (objMaruti is refered from objBMW which interns refers to same class) as classes are reference type it alters values of both objects.
            Console.WriteLine("changing object1 data");
            Console.WriteLine("Vehicle1 Make = {0} Model = {1}",objBMW.Make, objBMW.Model);
            Console.ReadKey();
        }
    }
}
