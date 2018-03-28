using System;

namespace CSI6111.Shared
{
    public interface ILogoff
    {
        bool Run();
    }

    /// <summary>
    /// Logoff the User
    /// </summary>
    public class Logoff : MarshalByRefObject, ILogoff
    {
        public bool Run()
        {
            Console.WriteLine("User logged Off");
            return true;
        }
    }
}
