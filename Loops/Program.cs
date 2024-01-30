 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] students = new string[3] { "Engin", "Tuğba", "Derin" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            int number = 100;
            while (number>=100)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine("Now number is {0}", number);
            Console.ReadLine();
            //for (int i = 1; i <=100; i++) {
            //    Console.WriteLine(i);
            //}   

        }
    }
}
