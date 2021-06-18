using System;
using System.Collections.Generic;
using System.Text;

namespace Authen
{
    public class Server : IAuthenticationService
    {
        public AuthToken Authenticate(string username, string password)
        {
            if (username == null && password == null)
            {
                throw new ArgumentNullException();
            }

            AuthToken token = new AuthToken();
            DateTime dateTime = new DateTime().ToLocalTime();
            token.Token = "33";
            token.ExpiresAt = dateTime.AddHours(2);
            return token;
        }
    }
}
