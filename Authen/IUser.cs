using System;
using System.Collections.Generic;
using System.Text;

namespace Authen
{
    public interface IUser
    {
        /// <summary>
        /// User's authentication token.
        /// </summary>
        String AuthToken { get; }
    }

}
