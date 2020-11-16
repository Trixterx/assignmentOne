using System;

namespace assignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assignment One";

            char opOne, opTwo;
            int nrOne = 0, nrTwo = 0, nrThree = 0, sum = 0;
            List<int> nrList = new List<int>();
            nrList.Add(22);


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
            if (opOne == '-')
            {
                sum = nrOne - nrTwo;
            }
            if (opOne == '*')
            {
                sum = nrOne * nrTwo;
            }
            if (opOne == '/')
            {
                sum = nrOne / nrTwo;
            }
            // Second operator
            if (opTwo == '+')
            {
                sum = sum + nrThree;
            }
            if (opOne == '-')
            {
                sum = sum - nrThree;
            }
            if (opOne == '*')
            {
                sum = sum * nrThree;
            }
            if (opOne == '/')
            {
                sum = sum / nrThree;
            }
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
        }
    }
}
