using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Model
{
    internal class Students
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private static int no = 0;
        private int _No;
        public int Id { get { return _No; } }
        public Groupum Group { get;set; }
        public Students()
        {
            no++;
            _No= no;
        }
        
    }
}
