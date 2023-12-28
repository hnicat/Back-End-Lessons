using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet Olmasa Istediyiniz Meblegi Girin:");
            double IstelinenKr=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zehmet Olmasa Ayliq Emek Haqqinizi Girin:");
            double Salary=Convert.ToDouble(Console.ReadLine());

            Kredit kredit = new Kredit(IstelinenKr, Salary);
            kredit.GetCredit(kredit.IstelinenKr, kredit.Maas);
            Console.WriteLine(kredit.verilecek);
            Console.ReadLine();
        }
    }
   public class Kredit
    {
        public double IstelinenKr { get; set; }
        public double Maas { get; set; }

        private double VerileBilcekKr;
      
        public Kredit(double istelinenkr,double maas)
        {
            IstelinenKr=istelinenkr;
            Maas=maas;  
        }
        public void GetCredit (double Credit,double Salary)
        {
            int Xercler = 250;
           
            int[] faiz = { 1, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60 };
            for(int i=0;i<faiz.Length; i++)
            {
 
                    double qaliq = Credit / (Salary - Xercler);
                    if (qaliq > 0 && qaliq <= faiz[i])
                    {
                        double UmumiKr = (((faiz[i] * 2) * Credit) / 100)+Credit;
                    double Qaliq = UmumiKr / (Salary - Xercler);
                    for (int h = 0; h < faiz.Length; h++)
                    {
                        if (Qaliq > 0 && Qaliq <= faiz[h])
                        {
                            VerileBilcekKr = UmumiKr;
                            break;
                        }
                    }
                    break;
                    }
                

           
               
            }

        }
        public double verilecek
        {
            get
            {
                Console.WriteLine("Size Vere Bileceyimiz Kredit Meblegi:");
                return VerileBilcekKr;

            }
        }


    }
}
