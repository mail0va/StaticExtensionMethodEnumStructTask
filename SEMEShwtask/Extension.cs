using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMEShwtask
{
    public static class Extension
    {
        public static bool CheckNotRobotCode(this string robotCode)
        {
            if (robotCode.Length < 5 && robotCode.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
