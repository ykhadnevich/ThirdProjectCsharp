using ConsoleAp3;

using KeyValuePair = ConsoleAp3.KeyValuePair;



var list = new StringsDictionary();
var lines = File.ReadAllLines("dictionary.txt");

foreach (var line in lines)
{
    var data = line.Split("; ");
    list.Add(data[0], data[1]);
}
while (true)
{
    Console.Write("Enter: ");
    var input = Console.ReadLine().ToUpper();
    var val = list.Get(input);
    if (val == null) {
        Console.WriteLine("Word not found!");
        continue;
    }

    Console.WriteLine(val.Value);
}




