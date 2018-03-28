using System;

namespace CSI6111.Shared
{
    public interface IRuOK
    {
        bool Run();
    }

    /// <summary>
    /// OK
    /// </summary>
    public class RuOK : MarshalByRefObject, IRuOK
    {
        public bool Run() { return true; }
    }
}
