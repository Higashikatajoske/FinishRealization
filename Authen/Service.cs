using System;
using System.Collections.Generic;
using System.Text;

namespace Authen
{
    public class Service : IAuthenticationService
    {
        public AuthToken Authenticate(string username, string password)
        {
            if (username == null && password == null)
            {
                throw new ArgumentNullException();
            }

            AuthToken token = new AuthToken();
            DateTime dateTime = new DateTime().ToLocalTime();
            Random random = new Random();
            token.Token = random.Next(0, 100).ToString();
            token.ExpiresAt = dateTime.AddHours(2);
            return token;
        }

        public Service()
        {

        }
    }
}
