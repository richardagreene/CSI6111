using System;
using System.Collections.Generic;
using System.Text;

namespace CSI6111.Shared
{
    public interface ILogoff
    {
        bool Run();
    }

    public class Logoff : MarshalByRefObject, ILogoff
    {
        public bool Run()
        {
            Console.WriteLine("User logged Off");
            return true;
        }
    }
}
