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

            List<double> numberList = new List<double>();
            char opOne, opTwo, retryOrEnd;
            double termOne, termTwo, termThree, sum = 0, numberListSum = 0;
            bool runProg = true;
            
            while (runProg == true)
            {
                Console.Write("Enter first operator: ");
                opOne = Console.ReadLine()[0];
                Console.Write("Enter second operator: ");
                opTwo = Console.ReadLine()[0];
                Console.Write("Enter first term: ");
                termOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second term: ");
                termTwo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter third term: ");
                termThree = Convert.ToInt32(Console.ReadLine());

                // First operator
                switch (opOne)
                {
                    case '+':
                        sum = termOne + termTwo;
                        break;
                    case '-':
                        sum = termOne - termTwo;
                        break;
                    case '*':
                        sum = termOne * termTwo;
                        break;
                    case '/':
                        sum = termOne / termTwo;
                        break;
                }

                // Second operator
                switch (opTwo)
                {
                    case '+':
                        sum += termThree;
                        break;
                    case '-':
                        sum -= termThree;
                        break;
                    case '*':
                        sum *= termThree;
                        break;
                    case '/':
                        sum /= termThree;
                        break;
                }

                numberList.Add(sum);
                Console.WriteLine($"{termOne} {opOne} {termTwo} {opTwo} {termThree} = {sum}");

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
                retryOrEnd = Console.ReadLine()[0];

                if (retryOrEnd == 'Y' || retryOrEnd == 'y')
                {
                    runProg = true;
                }
                else if (retryOrEnd == 'N' || retryOrEnd == 'n')
                {
                    runProg = false;
                }
            }

            for (int i = 0; i < numberList.Count; i++)
            {
                numberListSum += numberList[i];
            }
            Console.WriteLine($"Thank you for playing. The sum of all round is {numberListSum}. Counted using a for loop. Bye");
            Console.WriteLine($"Thank you for playing. The sum of all round is {numberList.Sum()}. Counted using Linq with .Sum(). Bye");
            Console.ReadKey();
        }
    }
}
