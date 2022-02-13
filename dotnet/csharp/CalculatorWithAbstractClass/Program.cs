using System;

namespace CalculatorWithAbstractClass
{
    abstract class AbstractClass {
        public abstract int Addition(int a, int b);
        public abstract int Substraction(int a, int b);
        public abstract int Multiplication(int a, int b);
        public abstract int Division(int a, int b);
       
    } 

    class Calculation: AbstractClass {
        public override int Addition(int a, int b){ return a+b; }
        public override int Substraction(int a, int b){ return a-b; }
        public override int Multiplication(int a, int b){ return a*b; }
        public override int Division(int a, int b){ return a/b; }
    }

    class Program
    {
        static void Main(string[] args){ 
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter your option");

            int input=0;
            Int32.TryParse(Console.ReadLine(),out input);

            Console.WriteLine("Enter Number 1: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int input2 = Convert.ToInt32(Console.ReadLine());            

            int result = 0;
            Calculation calculate = new Calculation();

            switch ( input ) {
                case 1: {
                    result = calculate.Addition(input1, input2);
                    break;
                }
                case 2: {
                    result = calculate.Substraction(input1, input2);
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

                default: {
                    Console.WriteLine("Wrong action!! try again");
                    break;
                }
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadLine();
        }
    }
}