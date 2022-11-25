using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTinkering
{
    public class ListTinkering
    {
        public static void EnumerateForeach()
        {
            List<string> strings = new List<string>()
            {
                "Hello",
                "World",
                "..."
            };

            foreach (var item in strings.Select((rinkyDink, i) => (rinkyDink, i)))
            {
                Console.WriteLine($"{item.i}\t{item.rinkyDink}");
            }
        }

        public static IEnumerable<string> YieldingForFunAndProfit()
        {
            yield return "One, nothing wrong with me";
            yield return "Two, nothing wrong with me";
            yield return "Three, nothing wrong with me";
            yield return "I don't know anymore of the lyrics lmao";
        }
    }
}
