using System;
using System.Collections.Generic;
using System.Linq;

namespace assignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProg();
        }
        static void RunProg()
        {
            Console.Title = "Assignment One";

            var numberList = new List<double>();
            char opOne, opTwo, retryOrEnd;
            double termOne, termTwo, termThree, opSum, numberListSum;
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

                opSum = DoOp(opOne, termOne, termTwo);
                opSum = DoOp(opTwo, opSum, termThree);
                numberList.Add(opSum);
                Console.WriteLine("{0} {1} {2} {3} {4} = {5}", termOne, opOne, termTwo, opTwo, termThree, opSum);

                if (opSum < 100)
                {
                    Console.WriteLine("Less then a hundred.");
                }
                else if (opSum > 100)
                {
                    Console.WriteLine("More then a hundred.");
                }
                else if (opSum == 100)
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
            numberListSum = EndSum(numberList);
            Console.WriteLine("Thank you for playing. The sum of all round is {0}. Counted using a for loop. Bye", numberListSum);
            Console.WriteLine("Thank you for playing. The sum of all round is {0}. Counted using Linq with .Sum(). Bye", numberList.Sum());
            Console.ReadKey();
        }
        static double EndSum(List<double> numberList)
        {
            double sum = 0;
            for (int i = 0; i < numberList.Count; i++)
            {
                sum += numberList[i];
            }
            return sum;
        }
        static double DoOp(char op, double x, double y)
        {
            double sum = 0;
            switch (op)
            {
                case '+':
                    sum = Addition(x, y);
                    break;
                case '-':
                    sum = Subtraction(x, y);
                    break;
                case '*':
                    sum = Multiplication(x, y);
                    break;
                case '/':
                    sum = Division(x, y);
                    break;
            }
            return sum;
        }
        static double Addition(double x, double y)
        {
            return x + y;
        }
        static double Subtraction(double x, double y)
        {
            return x - y;
        }          
        static double Multiplication(double x, double y)
        {
            return x * y;
        }           
        static double Division(double x, double y)
        {
            return x / y;
        }
    }
}
