using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Proj_Csharp_V4
{
    //The user CLASS is designed to store the information about the user and use the information later in the program
    class User
    {
        public string name;//user name - extract from mail
        public string mail;//user mail
        public User()
        {

        }

        public User(string name, string mail)
        {
            this.name = name;
            this.mail = mail;
        }

        public string Name { get => name; set => name = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
