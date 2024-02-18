using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExercise
{
    public class BasicMathProblems
    {
        public void PrintPrimeAmount(int counter) 
        {
            for (int i = 1; i <= counter; i++)
            {
                PrintPrimeNumbers(i);
            }
        }
        private  void PrintPrimeNumbers(int num)
        {
            if (num < 2)
            {
                Console.WriteLine($"{num} is not a prime number");
                return;
            }
            if (num == 2)
            {
                Console.WriteLine($"{num} is a prime number");
                return;
            }

            var sqrtNum = Math.Sqrt(num);
            for (int i = 2; i <= sqrtNum; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num} is not a Prime number");
                    return;
                }
            }
            Console.WriteLine($"{num} is prime number");

        }
    }
}
