using System;
using System.Collections.Generic;
using System.Text;

namespace Authen
{
    class User: IUser
    {
        public string AuthToken { get; set; }
        public string Name { get; }
        public string Password { get; }

        public User(string _name, string _password)
        {
            this.Name = _name;
            this.Password = _password;
            this.AuthToken = "0";
        }

        public void Autorization()
        {
            IAuthenticationService authService = new Service();
            this.AuthToken = authService.Authenticate(this.Name, this.Password).Token;
        }
    }
}
