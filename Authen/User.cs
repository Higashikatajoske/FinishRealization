using System;
using System.Collections.Generic;
using System.Text;

namespace Authen
{
    class User: IUser
    {
        public string AuthToken { get; }
        public string Name { get; }
        public string Surname { get; }

        public User(string _name, string _surname)
        {
            this.Name = _name;
            this.Surname = _surname;
            this.AuthToken = "0";
        }
    }
}
