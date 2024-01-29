using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
   public  class Janir
    {
        public static int id;
        private int _id;
        public string JanirName {  get; set; }
        
       public  int Id { get { return _id; } }
        public Janir(string janirname)
        {
            id++;
            JanirName= janirname;
            _id = id;
        }
    }
}
