using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    internal class Groupum
    {
       private static int count = 0;
        private int _id;

        public string  GName { get; set; }
        public int Id
        {
            get { return _id; }
        }
        public Groupum(string name) 
        {
            count++;
            _id=count;
            GName = name;

        }


    }
}
