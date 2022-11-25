using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTinkering
{
    internal class MoreDelegateTinkering
    {
        public delegate bool OneArgBoolDelegate(bool b);

        public void Main(int? what = null)
        {
            OneArgBoolDelegate lmao;

            if (what != null)
            {
                lmao = IsTrue;
            }
            else
            {
                lmao = IsFalse;
            }

            lmao(true);

        }

        private bool IsTrue(bool ba)
        {
            return ba;
        }

        private bool IsFalse(bool ba)
        {
            return false;
        }


    }
}
