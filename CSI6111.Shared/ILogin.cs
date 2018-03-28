using System;

namespace CSI6111.Shared
{
    public interface ILogin
    {
        bool Run(string username, string password);
    }

    /// <summary>
    /// Login Command
    /// </summary>
    public class Login : MarshalByRefObject, ILogin
    {
        public bool Run(string username, string password)
        {
            Console.WriteLine($"User: {username} login attempt.");
            return (username == "Username" && password == "password1234!");
        }
    }
}
