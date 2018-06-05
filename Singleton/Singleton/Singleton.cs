using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton a;

        private Singleton()
        {
        }

        public static Singleton getInstance()
        {

            if (a == null)
            {
                a = new Singleton();
            }
            return a;
        }
    }
}
