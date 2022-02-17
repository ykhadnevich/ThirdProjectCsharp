namespace ConsoleAp3;

public class KeyValuePair
{
    public string Key { get; }

    public string Value { get; }

    public KeyValuePair(string key, string value)
    {
        Key = key;
        Value = value;
    }
}

public class LinkedListNode
{
    public KeyValuePair Pair { get; }
        
    public LinkedListNode Next { get; set; }

    public LinkedListNode(KeyValuePair pair, LinkedListNode next = null)
    {
        Pair = pair;
        Next = next;
    }
}

public class LinkedList
{
    private LinkedListNode _first;
    
    public void Add(KeyValuePair pair)
    {
        if (_first == null)
        {
            _first = new LinkedListNode(pair);
            return;
        }
            
        var Current = _first;
        while (Current.Next != null)
        {
            Current = Current.Next;
        }

        Current.Next = new LinkedListNode(pair);
        
    }

    public void RemoveByKey(string key)
    {
        var Current = _first;
        if (Current == null) return;

        if (Current.Pair.Key == key) {
            _first = _first.Next;
            return;
        }

        while (Current.Next != null)
        {
            if (Current.Next.Pair.Key == key)
            {
                Current.Next = Current.Next.Next;
                return;
            }

            Current = Current.Next;
        } 
    }

    public KeyValuePair GetItemWithKey(string key)
    {
        var Current = _first;
        if (Current == null)
            return null;
        do
        { 
            if (Current.Pair.Key == key)
                return Current.Pair;
            Current = Current.Next;
        } while (Current != null);
        
        

        return null;
    }
}