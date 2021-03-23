using System;

namespace App1_Sir_Fibonacci
{
    class Program
    {
        /* Ex1. Să se determine și să se afișeze primii n termeni ai secvenței Fibonacci. (F0 = 0, F1 = 1, după care
se utilizează formula recursivă Fn = Fn-1 + Fn-2).*/

        static void Main(string[] args)
        {
            Console.Write("Sirul lui Fibonacci pentru n= ");
          
            int n = Convert.ToInt32(Console.ReadLine());

            // Initialize first elements
            int F0 = 0, F1 = 1;
            int F2;

            // Fibonacci
            for (int i = 1; i<=n; i++)
            {
                F2 = F1 + F0;
                F0 = F1;
                F1 = F2;

                Console.Write(F0 + " ");

            }
            
            Console.ReadKey();
        }
    }
}
