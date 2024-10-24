using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblem0001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Invoke th function
            Console.WriteLine("Project Euler Problem 001 " + SolveProjectEulerProblem001());
        }
        /// <summary>
        /// Uses a for loop to find all multiples of 3, 5, and 7
        /// </summary>
        /// <returns>Sum of all multiples of 3, 5, and 7 under 1000</returns>
        static int SolveProjectEulerProblem001()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
