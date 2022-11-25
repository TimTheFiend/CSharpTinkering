using CSharpTinkering;


var obj = ConditionalTinkering.ReturnClassOrNull(false);

if (obj?.MyBool == true)
{
    Console.WriteLine("hello");
}
if (!string.IsNullOrEmpty(obj?.MyProperty))
{
    Console.WriteLine("Oh my god");
}