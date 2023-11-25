using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lesson_4__Task_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ButunReqCem();

            // DortReqIndexYer();
            BesReqEnBoyukIndexYer();
            // BesReqEnKicikIndexYer();
            // EnboyukMasivVeIlkIndexYeri();
            // ArraydakIlkUceBoulunenEdedVeIndexYeri();
            // BesReqNeceDefeTekTap();
            // EnboyukMasivVeNeceDefeTek();
           
          
            Console.ReadLine();
           
        }
        public static void ButunReqCem()
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

            int n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                n += arr[i];
            }
            Console.WriteLine(n);

            Console.ReadLine();
        }

        public static void DortReqIndexYer()
        {

            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (4 == arr[i])
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        public static void BesReqEnBoyukIndexYer()
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            int c = 0;
            int b;
            for (int i = 0; i < arr.Length; i++)
            {
                if (5 == arr[i])
                {
                    b = i;
                    if (b > c)
                    {
                        c = b;

                    }
                }
            }
            Console.WriteLine(c);



            Console.ReadLine();
        }

        public static void BesReqEnKicikIndexYer()
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
           
            int b;
            for (int i = 0; i < arr.Length; i++)
            {
               
                if (5 == arr[i])
                {
                    b = i;
                    Console.WriteLine(b);
                    break;

                }
            }





            Console.ReadLine();
        }

        public static void EnboyukMasivVeIlkIndexYeri()
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

            int enboyuk = 0;
            int h = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= enboyuk)
                {
                    enboyuk = arr[i];
                }

            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (enboyuk == arr[i])
                {
                    h = i;
                    break;
                }

            }
            Console.WriteLine("Masivin en boyuk ededi:" + enboyuk + "ve ilk index yeri:" + h);
            Console.ReadLine();
        }

        public static void ArraydakIlkUceBoulunenEdedVeIndexYeri()
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            int ilkeded = 0;
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 2)
                {

                    ilkeded = arr[i]; break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (ilkeded == arr[i])
                {
                    c = i;
                    break;

                }
            }
            Console.WriteLine("Arraydaki Ilk 3 Bolunmeden Qaliqda 2 Alinan Reqem: " + ilkeded + " dir Ve Ilk index Yeri:" + c + "Dir");
            Console.ReadLine();
        }

        public static void BesReqNeceDefeTekTap()
        {

            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            int c = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (5 == arr[i])
                {
                    c++;
                }
            }
            Console.WriteLine("Arrayda 5 Ededi :"+c+" Defe Tekrarlanir");
            Console.ReadLine();

        }

        public static void EnboyukMasivVeNeceDefeTek()
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

            int enboyukeded = 0;
            int tekrar = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (enboyukeded <= arr[i])
                {
                    enboyukeded = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (enboyukeded == arr[i])
                {
                    tekrar++;
                }
            }

            Console.WriteLine("Masivin En Boyuk Ededi Budur :" + enboyukeded + " dir Ve bu eded " + tekrar + " defe tekrarlanir");
            Console.ReadLine();

        }
    }
}
