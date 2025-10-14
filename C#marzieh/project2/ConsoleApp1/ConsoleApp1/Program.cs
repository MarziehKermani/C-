using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass  //مرضیه کرمانی
    {
        static void Main()  
        {
            Console.WriteLine("hi enter a number:"); 

            string input = Console.ReadLine();  
            double r = Convert.ToDouble(input); 

            double masahat = 3.14 * r * r;  
            double mohit = 2 * 3.14 * r;   

            Console.WriteLine("masahat: " + masahat); 
            Console.WriteLine("mohit: " + mohit);

            Console.ReadLine();  
        }
    }
}
