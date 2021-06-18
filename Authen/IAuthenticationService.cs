using System;
using System.Collections.Generic;
using System.Text;

namespace Authen
{
    interface IAuthenticationService
    {
        /// <summary>
        /// Authenticates user.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        /// <returns>Authentication token.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when <paramref name="username"/> or <paramref name="password"/> is null.
        /// </exception>
        AuthToken Authenticate(String username, String password);
    }

}
