﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)


           
        {
            string city = "Ankara";
            // Console.WriteLine(city[0]);
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }

            string city2 = "İstanbul";
            
            Console.WriteLine(String.Format("{0} {1}", city, city2));

             
            Console.ReadLine();
        }
    }
}
