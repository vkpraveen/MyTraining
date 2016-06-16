using System;
using System.IO;


namespace Schedule1
{
   public class Program
    {
       
             public  class Programp
        {
            int a;
            diff d = new diff();
        
            protected void ex()
            {
                Console.WriteLine("This is a method under class");
              }
        }

        class nest
        {
            Program p = new Program();
            class innernest
            {
              nest i = new nest();
               Console.WriteLine("this is a nested class");
              
            }
        }
        nest n = new nest();

        class diff
        {
            nest n1 = new nest();
            Console.WriteLine("this ia a different class");
        }
        nest n2 = new nest();
       

        class empty
        {
            Console.WriteLine("This is a empty class")
        }
        Programp p = new Programp();
        p.ex();
    }
   static void main (String args[])
    {
    }

}
    

