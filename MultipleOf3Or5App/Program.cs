using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleOf3Or5App
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            Console.WriteLine(Solution(value)); 
        }

        static int Solution(int value)
        {
            const int three = 3, five = 5;
            int results = 0, number = 0; 
            List<int> total = new List<int>();

            results = value / three;

            for (int i = 0; i < results; i++)
            {
                number += 3;
                if (Checker(value, number))
                    break;
                total.Add(number);
            }

            results = value / five;
            number = 0;

            for (int i = 0; i < results; i++)
            {
                number += 5;
                if (Checker(value, number))
                    break;
                total.Add(number);
            }

            return total.GroupBy(x => x).Where(y => y.Count() > 0).Select(z => z.Key).Count() > 0 ?
                total.GroupBy(x => x).Where(y => y.Count() > 0).Select(z => z.Key).Sum() :
                total.Select(x => x).Sum(); 

        }

        static bool Checker(int parsedNumber, int multipleof)
        {
            if (multipleof == parsedNumber)
                return true;
            return false;
        }
    }
}
