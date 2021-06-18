using System;
using System.Collections.Generic;
using System.Text;

namespace Authen
{
    public class AuthToken
    {
        /// <summary>
        /// Authentication token string.
        /// </summary>
        public String Token { get; set; }
        /// <summary>
        /// Date and time the token expires at (UTC).
        /// </summary>
        public DateTime ExpiresAt { get; set; }
    }

}
