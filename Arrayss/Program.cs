using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] students = new string[3];

            students[0] = "Tuğba";
            students[1] = "Muhammet";
            students[2] = "Derin";

            foreach (string s in students) {
            Console.WriteLine(s);
            }
            string[,] regions = new string[5,2]
            {
                {"İstanbul","İzmit" },
                { "Ankara", "Konya"},
                { "Antalya", "Adana"},
                { "Rize", "Düzce"},
                { "İzmir", "Muğla"},
                
            };

            for (int i = 0; i < regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j < regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }   
            }

            Console.ReadLine(); 
        }
    }
}
