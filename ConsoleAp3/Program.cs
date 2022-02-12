using ConsoleAp3;
using KeyValuePair = ConsoleAp3.KeyValuePair;

var list = new LinkedList();
var lines = File.ReadAllLines("dictionary.txt");
foreach (var line in lines)
{
    var data = line.Split("; ");
    list.Add(new KeyValuePair(data[0], data[1]));
}
while (true)
{
    Console.Write("Enter: ");
    var input = Console.ReadLine().ToUpper();
    var val = list.GetItemWithKey(input);
    if (val == null) {
        Console.WriteLine("Word not found!");
        continue;
    }

    Console.WriteLine(val.Value);
}




