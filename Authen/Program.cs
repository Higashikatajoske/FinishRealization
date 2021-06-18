using System;

namespace Authen
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Nikolay", "tetra");
            user.Autorization();
        }
    }
}
