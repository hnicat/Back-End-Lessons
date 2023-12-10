using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static void task1()
        {
        Dictionary<string, string> CountryCity = new Dictionary<string, string>();


        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " Please Enter Country Name");
            string country = Console.ReadLine();
            Console.WriteLine(i + " Note the Capital of the Country if you don't mind:");
            string city = Console.ReadLine();
            CountryCity.Add(country, city);
        }
            //Console.Write( " Do you want to choose country:");
            //string word;
            //word=Console.ReadLine();

            while (true)
            {   
                Console.WriteLine("Dear customer! Please enter the city name nearby.");

                string search = Console.ReadLine();
                foreach (var item in CountryCity)
                {
                    if (item.Key == search)
                    {
                        Console.WriteLine(item.Value);
                    }
                    else if (search == "All")
                    {
                        Console.WriteLine(item);
                    }
                 

                }

                Console.WriteLine("search for a new capital? Y/N");
                string yesno = Console.ReadLine();
                if (yesno == "Y")
                {
                    continue;
                }
                if (yesno == "N")
                {
                    break;
                }
                Console.ReadLine();
            }
        }
        public static void task2()
        {
            Queue<string> message = new Queue<string>();

            byte a = 10;
            while (true)
            {
                Console.WriteLine("Do you want to enter a message?");
                string yesno = Console.ReadLine();
                if (yesno == "Yes")
                {
                    Console.WriteLine("Enter the sentence");
                    string Sentence = Console.ReadLine();
                    message.Enqueue(Sentence);
                    if (message.Count > a)
                    {
                        message.Dequeue();
                        message.Enqueue(Sentence);
                    }

                }
                else if (yesno == "No")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Select Yes Or No");
                }
            }
        }
        public static void task3()
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Please enter a new number:");
                int number = Convert.ToInt16(Console.ReadLine());
                list.Add(number);
            }

            for (int i = 0; i < 5; i++)
            {
                int temp;
                temp = list[i];
                list[i] = list[i + 5];
                list[i + 5] = temp;
            }
            foreach (int item in list)
            {
                Console.WriteLine(item + " Number Location Set ");
            }
            Console.ReadLine();
        }
        public static void task4()
        {
            SortedList<int, string> sort = new SortedList<int, string>();
            byte a = 0;
            while (true)
            {
                a++;
                Console.WriteLine("Please enter a number:");
                int Number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the written form of the number you entered");
                string Number2 = Console.ReadLine();
                int b = Number1;
                sort.Add(Number1, Number2);
                if (a == 5)
                {
                    break;
                }

            }

            foreach (var item in sort.Keys)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadLine();
        }
    }
}
