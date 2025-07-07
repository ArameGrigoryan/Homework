namespace HashTable;

public class HashingTable
{
    private double _loadFactor = 0.75;
    private int _elementCount;
    private static int _slotCount = 17;
    private LinkedList<KeyValuePair<object, object>>[] _slots;

    public HashingTable()
    {
        _slots = new LinkedList<KeyValuePair<object, object>>[_slotCount];
    }
    public object? this[object Key]
    {
        get
        {
            return Search(Key);
        }
        set
        {
            int index = IndexOfSlot(Key);
            if (_slots[index] == null)
            {
                return;
            }
            else
            {
                var node = _slots[index].First;
                while (node != null)
                {
                    if (node.Value.Key == Key)
                    {
                        node.Value = new KeyValuePair<object, object>(Key, value);
                        break;
                    }
                    node  = node.Next;
                }
            }
        }
    }
    public void Add(object key, object value)
    {
        if (Search(key) != null)
        {
            Console.WriteLine("This key exist");
            return;
        }
        KeyValuePair<object, object> pair = new KeyValuePair<object, object>(key, value);

        int index = IndexOfSlot(pair.Key);
        if ((double)_elementCount / _slotCount > _loadFactor)
        {
            Rehashing();
        }
        if (_slots[index] == null)
        {
            _slots[index] = new LinkedList<KeyValuePair<object, object>>();
        }
        _slots[index].AddLast(pair);
        ++_elementCount;
    }
    public object Search(object key)
    {
        int index = IndexOfSlot(key);
        if (_slots[index] != null)
        {
            foreach (var item in _slots[index])
            {
                if (item.Key == key)
                {
                    return item.Value;
                }
            }
        }
        return null;
    }
    public void Remove(object key)
    {
        if (Search(key) == null)
        {
            Console.WriteLine("This key is not found");
            return;
        }
        else
        {
            int index = IndexOfSlot(key);
            if (_slots[index] != null)
            {
                foreach (var item in _slots[index])
                {
                    if (item.Key == key)
                    {
                        _slots[index].Remove(item);
                        --_elementCount;
                        return;
                    }
                }
            }
        }
    }
    private void Rehashing()
    {
        int oldCount = _slotCount;
        int newSlotCount = NextPrime(_slotCount * 2);
        var newslots = new LinkedList<KeyValuePair<object, object>>[_slotCount];
        for (nint i = 0; i < oldCount; ++i)
        {
            if (_slots[i] != null)
            {
                foreach (var item in _slots[i])
                {
                    int hashIndex = IndexOfSlot(item.Key, newSlotCount);
                    if (newslots[hashIndex] == null)
                    {
                        newslots[hashIndex] = new LinkedList<KeyValuePair<object, object>>();
                    }
                    newslots[hashIndex].AddLast(item);
                }
            }
        }
        _slots = newslots;
        _slotCount = newSlotCount;
    }
    private int NextPrime(int n)
    {
        if (n <= 2)
            return 2;
        while (!IsPrime(n))
            n++;
        return n;
    }
    private bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        int boundary = (int)Math.Sqrt(number);
        for (int i = 3; i <= boundary; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
    private int IndexOfSlot(object key)
    {
        int hash = key.GetHashCode();
        return Math.Abs(hash) % _slotCount;
    }
    private int IndexOfSlot(object Key, int slotCount)
    {
        int hash = Key.GetHashCode();
        return Math.Abs(hash) % slotCount;
    }

}