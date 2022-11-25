using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTinkering
{
    public class ConditionalTinkering
    {
        // Checks if the object is null before going past the ?.
        // (Is `foo` == null? No -> CompareTo
        public static bool QuestionmarkPeriod()
        {
            Random rng = new Random();

            int? foo = rng.NextSingle() > 0.5 ? 5 : null;

            return foo?.CompareTo(0) >= 0 ? true : false;
        }

        public static ConditionalClass ReturnClassOrNull(bool isReturningNull)
        {
            var obj = new ConditionalClass();
            return isReturningNull ? obj : null;
        }

    }

    public class ConditionalClass
    {
        public string MyProperty { get; set; } = "Hello World";
        public bool MyBool { get; set; } = true;

    }


}
