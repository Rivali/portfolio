﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[8];
            int x;
            string inputString;

            for (x = 0; x < scores.Length; ++x)
            {
                Console.Write("Enter your score on test {0}: ", x + 1);
                inputString = Console.ReadLine();
                scores[x] = Convert.ToInt32(inputString);
            }

            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Scores in original order:");
            for (x = 0; x < scores.Length; ++x)
            {
                Console.Write("{0,6}", scores[x]);
            }

            Console.WriteLine("\n---------------------------------");
            Array.Sort(scores);
            Console.WriteLine("Scores from lowest to highest:");
            for (x = 0; x < scores.Length; ++x)
            {
                Console.Write("{0,6}", scores[x]);
            }

            Console.WriteLine("\n---------------------------------");
            Array.Reverse(scores);
            Console.WriteLine("Scores from highest to lowest");
            for (x = 0; x < scores.Length; ++x)
            {
                Console.Write("{0,6}", scores[x]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
