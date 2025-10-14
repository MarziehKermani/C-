using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //مرضیه کرمانی //
            Console.WriteLine("Enter a Celsius :");  

            string input = Console.ReadLine();  
            double c = Convert.ToDouble(input); 

            double f = (c * 9 / 5) + 32;  

            Console.WriteLine("Fahrenheit: " + f);  

            Console.ReadLine(); 
        }
    }
}
