using System;
using Functions;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition: ");
            Console.WriteLine("Press 2 for Subraction: ");
            Console.WriteLine("Press 3 for Multiplication: ");
            Console.WriteLine("Press 4 for Division: \n ");
            int action = 0;
            bool isParsed = Int32.TryParse(Console.ReadLine(), out action);
            Console.WriteLine(isParsed);
            Console.WriteLine("Enter Number 1: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            Calculation calculate = new Calculation();

            switch(action) {
                case 1: {
                    result = calculate.Addition(input1, input2);
                    break;
                }
                case 2: {
                    result = calculate.Subtraction(input1, input2);
                    break;
                }
                case 3: {
                    result = calculate.Multiplication(input1, input2);
                    break;
                }
                case 4: {
                    result = calculate.Division(input1, input2);
                    break;
                }

                default: 
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
        }
    }
}
