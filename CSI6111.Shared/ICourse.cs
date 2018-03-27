using System;
using System.Collections.Generic;
using System.Text;

namespace CSI6111.Shared
{
    public interface ICourse
    {
        bool Run(string strProgramName, string strArgumentString);
    }

    public class Course : MarshalByRefObject, ICourse
    {
        public Course()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public bool Run(string strProgramName, string strArgumentString)
        {
            Console.WriteLine(strProgramName, strArgumentString);
            return false;
        }
    }
}
