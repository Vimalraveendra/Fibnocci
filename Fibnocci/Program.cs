using System;
using System.Threading.Tasks;

namespace Fibnocci
{
   
    class Program
    {

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }


        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter the length of the fibinocci:");
            int len = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 0; i < len; i++)
            {
                await Task.Delay(3000); 
                Console.WriteLine(Fibonacci(i));
                
            }
        }

        
    }
}
