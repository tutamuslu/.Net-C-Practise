using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(number1, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            //Console.WriteLine(Add2(5, 2));
            Console.WriteLine(Multiply(2, 4));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }
       
        static int Add3(int number1, int number2)
        {
            return number1 + number2;

        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Add4(params int [] numbers) 
        {
            return numbers.Sum();
        }
        
    }
}
