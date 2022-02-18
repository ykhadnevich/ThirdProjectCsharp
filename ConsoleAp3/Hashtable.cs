namespace ConsoleAp3;

public class StringsDictionary
{
    private static int Size = 10000;

    private LinkedList[] _buckets = new LinkedList[Size];

    public void Add(string key, string value)
    {
       var index = CalculateHash(key);
       if (_buckets[index] == null) _buckets[index] = new LinkedList();
       _buckets[index].Add(new KeyValuePair(key, value));
    }

    public void Remove(string key)
    {
       var index = CalculateHash(key);
       if (_buckets[index] == null) return;
       _buckets[index].RemoveByKey(key); 
    }

    public KeyValuePair Get(string key)
    {
       var index = CalculateHash(key);
       if (_buckets[index] == null) return null;
       return _buckets[index].GetItemWithKey(key);
    }

    private int CalculateHash(string key)
    {
      return Math.Abs(key.GetHashCode()) % Size;
    }
}

