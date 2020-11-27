using System;
using System.Collections.Generic;
using System.Linq;

namespace assignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }
        static void StartProgram()
        {
            var numberList = new List<double>();
            char opOne, opTwo, retry;
            double termOne, termTwo, termThree, sum, numberListSum;
            bool runProg = true;

            Console.Title = "Assignment One";

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

                sum = DoOp(opOne, termOne, termTwo);
                sum = DoOp(opTwo, sum, termThree);
                numberList.Add(sum);
                Console.WriteLine("{0} {1} {2} {3} {4} = {5}", termOne, opOne, termTwo, opTwo, termThree, sum);

                if (sum < 100)
                {
                    Console.WriteLine("Less then a hundred.");
                }
                else if (sum == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap");
                }
                else
                {
                    Console.WriteLine("More then a hundred.");
                }

                Console.WriteLine("Try again? y/n");
                retry = Console.ReadLine()[0];

                if (retry == 'Y' || retry == 'y')
                {
                    runProg = true;
                }
                else if (retry == 'N' || retry == 'n')
                {
                    runProg = false;
                }
            }
            numberListSum = CalcEndSum(numberList);
            Console.WriteLine("Thank you for playing. The sum of all round is {0}. Counted using a for-loop. Bye", numberListSum);
            Console.WriteLine("Thank you for playing. The sum of all round is {0}. Counted using Linq with .Sum(). Bye", numberList.Sum());
            Console.ReadKey();
        }
        static double DoOp(char op, double a, double b)
        {
            double sum = 0;
            switch (op)
            {
                case '+':
                    sum = Addition(a, b);
                    break;
                case '-':
                    sum = Subtraction(a, b);
                    break;
                case '*':
                    sum = Multiplication(a, b);
                    break;
                case '/':
                    sum = Division(a, b);
                    break;
            }
            return sum;
        }
        static double Addition(double a, double b)
        {
            return a + b;
        }
        static double Subtraction(double a, double b)
        {
            return a - b;
        }          
        static double Multiplication(double a, double b)
        {
            return a * b;
        }           
        static double Division(double a, double b)
        {
            return a / b;
        }
        static double CalcEndSum(List<double> numberList)
        {
            double sum = 0;
            for (int i = 0; i < numberList.Count; i++)
            {
                sum += numberList[i];
            }
            return sum;
        }
    }
}
