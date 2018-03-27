using System;
using System.Collections.Generic;
using System.Text;

namespace CSI6111.Shared
{
    public interface ILogin
    {
        bool Run(string username, string password);
    }

    public class Login : MarshalByRefObject, ILogin
    {
        public bool Run(string username, string password)
        {
            Console.WriteLine($"User: {username} login attempt.");
            return (username == "Username" && password == "password1234!");
        }
    }
}
