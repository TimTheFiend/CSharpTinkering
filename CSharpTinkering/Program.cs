using CSharpTinkering;




Func<string, string> toUpper = str => str.ToUpper();

Func<string, bool> HelloDude = x => x.Length > 1;

Func<string, string> h = str => str = "Hello kitty";

List<string> foo = new List<string> {
    "hi",
    "he",
    "ho"
};


List<string> bar = foo.Select(toUpper).ToList();
List<bool> baz = foo.Select(HelloDude).ToList();
List<string> bam = foo.Select(h).ToList();

foreach (var item in bam)
    Console.WriteLine(item);

foreach (var item in baz)
    Console.WriteLine(item);