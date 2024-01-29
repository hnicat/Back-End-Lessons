using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    internal class UserInformation
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public UserInformation(string name,string password)
       {
            Name = name;
            Password = password;
       }

    }
}
