using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Task_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ci Ededi Daxil Edin:");
            double Eded1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2 ci Ededi Daxil Edin:");
            double Eded2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Simvolu Daxil Edin:");

            string simvol = Console.ReadLine();

            switch (simvol)
            {
                case "+":Console.WriteLine("Netice: " + Eded1 + Eded2);break;

                case "-":Console.WriteLine("Netice: " + (Eded1 - Eded2));break;

                case "*":Console.WriteLine("Netice: " + Eded1 * Eded2);break;

                case "/":Console.WriteLine( "Netice: "+Eded1 / Eded2);break;

                default:Console.WriteLine("Simvol Duz Daxil Edilmedi !");break;


            }
            Console.ReadLine();

        }
    }
}
