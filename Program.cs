using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n=int.Parse(Console.ReadLine());
            for(int i = 1; i<=n; i++)
            {
               for(int j = 1; j <=i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for(int i = n; i>=1; i--)
            {
                for(int j =i ; j>=1 ; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
