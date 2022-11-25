using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTinkering
{
    public class ConsoleTinkering
    {
        // \r = Resets the cursor to the current line. after printing.
        public static void PrintToSameLine()
        {
            int timeDelay = 75;

            for (int i = 0; i < 100 + 1; i++)
            {
                Console.Write($"\r{i.ToString().PadLeft(3, '0')}");
                Thread.Sleep(timeDelay);
            }
        }
    }
}
