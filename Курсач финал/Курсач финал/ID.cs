using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_финал
{
    public static class ID
    {
        private static int id;
        public static int getid ()
        {
            return (id);
        }
        public static void changeid (int q)
        {
            id = q;
        }
    }
    public static class IDp
    {
        private static int id;
        public static int getid()
        {
            return (id);
        }
        public static void changeid(int q)
        {
            id = q;
        }
    }
}
