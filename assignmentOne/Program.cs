using System;
using System.Collections.Generic;
using System.Linq;

namespace assignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProg();
        }
        static void StartProg()
        {
            var numberList = new List<double>();
            char op1, op2, retry;
            double term1, term2, term3, sum;
            bool runProg = true;

            Console.Title = "Assignment One";

            while (runProg == true)
            {
                Console.Write("Enter first operator: ");
                op1 = Console.ReadLine()[0];
                Console.Write("Enter second operator: ");
                op2 = Console.ReadLine()[0];
                Console.Write("Enter first term: ");
                term1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second term: ");
                term2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter third term: ");
                term3 = Convert.ToInt32(Console.ReadLine());

                sum = DoOp(op1, term1, term2);
                sum = DoOp(op2, sum, term3);
                numberList.Add(sum);
                Console.WriteLine("{0} {1} {2} {3} {4} = {5}", term1, op1, term2, op2, term3, sum);

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
            sum = CalcEndSum(numberList);
            Console.WriteLine("Thank you for playing. The sum of all round is {0}. Counted using a for-loop. Bye", sum);
            Console.WriteLine("Thank you for playing. The sum of all round is {0}. Counted using Linq with .Sum(). Bye", numberList.Sum());
            Console.ReadKey();
        }
        static double DoOp(char op, double a, double b)
        {
            double sum = 0;
            switch (op)
            {
                case '+':
                    sum = a + b;
                    break;
                case '-':
                    sum = a - b;
                    break;
                case '*':
                    sum = a * b;
                    break;
                case '/':
                    sum = a / b;
                    break;
            }
            return sum;
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
