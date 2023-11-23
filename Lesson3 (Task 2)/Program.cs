using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3__Task_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] telebeler = { "Nicat", "Amin", "Sahin", "Tural", "Elgun", "Resul" };
            Console.WriteLine("Telebenin Adi:");
            for(int i=0; i<telebeler.Length; i++)
            {
                Console.WriteLine(telebeler[i]);
                int netice = Convert.ToByte(Console.ReadLine());
                switch (netice)
                {
                    case int a when (a >= 90 && a <= 100):
                        Console.WriteLine(telebeler[i] + "Adinda Telebenin Neticesi A");break;
                    case int a when (a >= 80 && a <= 89):
                        Console.WriteLine(telebeler[i] + "Adinda Telebenin Neticesi B"); break;
                    case int a when (a >= 70 && a <= 79):
                        Console.WriteLine(telebeler[i] + "Adinda Telebenin Neticesi C"); break;
                    case int a when (a >= 60 && a <= 69):
                        Console.WriteLine(telebeler[i] + "Adinda Telebenin Neticesi D"); break;
                    case int a when (a >= 0 && a <= 59):
                        Console.WriteLine(telebeler[i] + "Adinda Telebe Kesildi"); break;

                    default:Console.WriteLine("Bal Duzgun Daxil Edilmedi !");break;


                }
            }
        }
    }
}
