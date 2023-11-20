using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator__Lesson_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ci Ededi Daxil Edin:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 ci Ededi Daxil Edin:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("2 Ededin Cemi");
            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}
