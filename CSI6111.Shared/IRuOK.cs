using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI6111.Shared
{
    public interface IRuOK
    {
        bool Run();
    }

    public class RuOK : MarshalByRefObject, IRuOK
    {
        public bool Run() { return true; }
    }
}
