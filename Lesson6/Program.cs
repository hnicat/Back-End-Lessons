
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__6_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string data = Console.ReadLine();
            //Console.WriteLine(data.Contains(data));
            //IsNullOrEmpty(data);

            //Console.WriteLine("Sozu Daxil Edin:");
            //string data = Console.ReadLine();
            //Console.WriteLine("Ikinci Sozu Daxil Edin:");
            //string data2 = Console.ReadLine();
            //Equals(data, data2);

            //string data = Console.ReadLine();
            //Length(data);

        }

        public static void IsNullOrEmpty(string data)
        {
            if (data.Length == null)
            {
                Console.WriteLine("Nulldir");
            }
            else
            {
                Console.WriteLine("Null Deyil");
            }
            Console.ReadLine();
        }

        public static void Equals(string data, string data2)
        {

            if (data.ToLower().Trim()== data2.ToLower().Trim())
            {
                Console.WriteLine("Bu Sozler Equals dir");
            }
            else
            {
                Console.WriteLine("Bu Sozler Equals Deyil");
            }
            Console.ReadLine();
        }

        public static void Length(string uzunluq)
        {
            int counter = 0;
            foreach (var item in uzunluq)
            {
                counter++;
            }
            Console.WriteLine(uzunluq+" Sozunun Uzunluqu "+counter);
            Console.ReadLine();
        }

        public static void Contains(string data, string data2)
        {
            string resualt = "";
            for (int i = 0; i < data.Length; i++)
            {
                resualt += data[i];
                if (resualt == data2)
                {
                    Console.WriteLine("Beli Var");
                    break;
                }
            }
        }

    }
}
