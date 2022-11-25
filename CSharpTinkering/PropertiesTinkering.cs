using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTinkering
{
    public class GetPropertiesTinkering
    {
        public string stringProp { get; private set; } = "Cawadoody";
        public int intProp { get; private set; } = 2;
        public string nameIGuess { get; private set; } = "Modern Waawfaah";
    }

    public static class PrintProperties
    {
        public static void Print()
        {
            GetPropertiesTinkering foo = new GetPropertiesTinkering();
            foreach (var prop in foo.GetType().GetProperties())
            {
                Console.WriteLine($"{prop.Name}={prop.GetValue(foo, null)}");
            }
        }
    }
}
