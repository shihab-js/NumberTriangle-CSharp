using System;

namespace NumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the variables
            int i, j, k, l, n;

            //print show message
            Console.Write("Please enter the range: ");

            //catch the user input
            n = int.Parse(Console.ReadLine());

            //for loop to continue the program
            for(i=1; i <= n; i++)
            {
                for (j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for(k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                for(l = i-1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.Write("\n");
            }
        }
    }
}
