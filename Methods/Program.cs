﻿using System;
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
            Add();
            Console.WriteLine(Add2(5, 2));
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
    }
}
