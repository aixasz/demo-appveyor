using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppVeyor
{
    public static class WordHelpers
    {
        public static Func<string, string, string> Fullname = (x, y) => string.Format("{0} {1}", x, y);
    }
}
