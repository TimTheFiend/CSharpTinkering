using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTinkering
{
    internal class MoreDelegateTinkering
    {

        public static void UseEncapsulatedFunction(Func<bool> action)
        {
            if (action())
            {
                Console.WriteLine("action returns true");
            }
            else
            {
                Console.WriteLine("action returns false");
            }
        }

        public static Func<bool> GetFunction()
        {
            return ReturnFalse;
        }

        private static bool ReturnFalse()
        {
            return false;
        }

        public static bool IsTrue()
        {
            return true;
        }
    }
}
