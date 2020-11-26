﻿using System;
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
                else if (sum > 100)
                {
                    Console.WriteLine("More then a hundred.");
                }
                else if (sum == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap");
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
            Console.WriteLine("Thank you for playing. The sum of all round is {0}. Counted using a for loop. Bye", numberListSum);
            Console.WriteLine("Thank you for playing. The sum of all round is {0}. Counted using Linq with .Sum(). Bye", numberList.Sum());
            Console.ReadKey();
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
