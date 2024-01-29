using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
   public  class Kitab
    {
        public static int no;
        public string BookName { get; set; }
        public int  Pirce { get; set; }

        public Janir janir { get; set; }

        public int ISBN { get; set; }
       public int id { get; set; }
        public Kitab(int isbn, string bookname, int pirce)
        {
            ISBN= isbn;
            no++;
            id = no;
            Pirce = pirce;
            BookName = bookname;
        }
        
      




    }
}
