using System;

namespace DelegateDemoMastek
{
    //1. Declare delegate
    delegate int CalculatorDelegate(int first, int second);
    
    class Program
    {
        //2.Declare method
        static int AddNumbers(int number1,int number2)
        {
            return number1 + number2;
        }
        static int MultiNumbers(int num1,  int num)
        {
            return num1 * num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //3.Create deligate instance
            CalculatorDelegate demo1 = new CalculatorDelegate(AddNumbers);

            //4.Involke deligate
            int result = demo1(5, 4);
            int res1 = demo1(8, 9);
            Console.WriteLine("Addition : " + result);
            Console.WriteLine("Multiplication : " + res1);

            // lambda expression for addition
            CalculatorDelegate demo2 = (a, b) => a + b;
            result = demo2(8, 7);
            Console.WriteLine("Addition using lamda: " + result);

            //lamda expression for subtraction
            CalculatorDelegate demo3 = (a, b) => a - b;
            result = demo3(7, 5);
            Console.WriteLine("subtraction is: " + result);

            //lamda expression for multiplication
            CalculatorDelegate demo4 = (x, y) => x * y;
            result = demo4(7, 5);
            Console.WriteLine("Multiplication is: " + result);

            //lamda expression for division
            CalculatorDelegate demo5 = (p, q) => p % q;
            result = demo5(10, 5);
            Console.WriteLine("Division is: " + result);
        }
    }
}
