using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTinkering
{
    public static class SwitchCaseTinkering
    {
        public static void BetweenValues(int input = 10)
        {
            switch (input)
            {
                case int x when (x >= 7):
                    Console.WriteLine("bigger than 6");
                    break;
                case int x when (x < 7 && x >= 2):
                    Console.WriteLine("bigger than 1 and lower than 7");
                    break;
                default:
                    Console.WriteLine("1 or smaller");
                    break;
            }
        }

        public static void FallThrough(int input = 5)
        {
            switch (input)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("input do be low");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("input, more like inputty");
                    break;
                case 5:
                    goto case 69;
                case 6:
                    Console.WriteLine("fuck you, *exits program*");
                    Environment.Exit(0);
                    break;
                case 69:
                    Console.WriteLine("nice");
                    break;

                default:
                    break;
            }
        }

    }
}
