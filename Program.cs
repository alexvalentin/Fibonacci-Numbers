using System;
using System.Collections.Generic;

namespace App1_Sir_Fibonacci
{
    class Program
    {
        /* Să se determine și să se afișeze primii n termeni ai secvenței Fibonacci. (F0 = 0, F1 = 1, după care
se utilizează formula recursivă Fn = Fn-1 + Fn-2).*/

        /* Determine and display the first n terms of the Fibonacci sequence. (F0 = 0, F1 = 1, after which
the recursive formula Fn = Fn - 1 + Fn - 2 is used). */

        static void Main(string[] args)
        {
            Console.Write("The Fibonacci sequence for n = ");
          
            int n = Convert.ToInt32(Console.ReadLine());

            // Initialize first elements
            int F0 = 0, F1 = 1, F2;

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
