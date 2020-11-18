using System;
using System.Collections.Generic;
using System.Linq;

namespace assignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assignment One";

            List<double> nrList = new List<double>();
            char opOne, opTwo, endChar;
            double nrOne, nrTwo, nrThree, sum = 0, nrListSum = 0;
            bool endBool = false;

            do
            {
                Console.Write("Enter first operator: ");
                opOne = Console.ReadLine()[0];

                Console.Write("Enter second operator: ");
                opTwo = Console.ReadLine()[0];

                Console.Write("Enter first term: ");
                nrOne = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second term: ");
                nrTwo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter third term: ");
                nrThree = Convert.ToInt32(Console.ReadLine());

                // First operator
                if (opOne == '+')
                {
                    sum = nrOne + nrTwo;
                }
                else if (opOne == '-')
                {
                    sum = nrOne - nrTwo;
                }
                else if (opOne == '*')
                {
                    sum = nrOne * nrTwo;
                }
                else if (opOne == '/')
                {
                    sum = nrOne / nrTwo;
                }

                // Second operator
                if (opTwo == '+')
                {
                    sum = sum + nrThree;
                }
                else if (opTwo == '-')
                {
                    sum = sum - nrThree;
                }
                else if (opTwo == '*')
                {
                    sum = sum * nrThree;
                }
                else if (opTwo == '/')
                {
                    sum = sum / nrThree;
                }

                nrList.Add(sum);
                Console.WriteLine($"{nrOne} {opOne} {nrTwo} {opTwo} {nrThree} = {sum}");

                if (sum < 100)
                {
                    Console.WriteLine("Less then a hundred.");
                }
                else if (sum > 100)
                {
                    Console.WriteLine("More then a hundred.");
                }
                else if (sum == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap");
                }

                Console.WriteLine("Try again? y/n");
                endChar = Console.ReadLine()[0];

                if (endChar == 'Y' || endChar == 'y')
                {
                    endBool = false;
                }
                else if (endChar == 'N' || endChar == 'n')
                {
                    endBool = true;
                }

            } while (endBool == false);

            // Using two different methods to get the sum of the list. One with for loop that adds together the objects and one with Linq with .Sum().
            for (int i = 0; i < nrList.Count; i++)
            {
                nrListSum = nrListSum + nrList[i];
            }
            Console.WriteLine($"Thank you for playing. The sum of all round is {nrListSum}. Counted using a for loop. Bye");
            Console.WriteLine($"Thank you for playing. The sum of all round is {nrList.Sum()}. Counted using Linq with .Sum(). Bye");
            Console.ReadKey();
        }
    }
}
