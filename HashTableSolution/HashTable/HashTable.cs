namespace HashTable;

// For simplicity our hashtable has keys that are strings
// and values that are integers
public class HashTable<T>
{
    private List<Entry<T>>[] _table = new List<Entry<T>>[1_000_000];

    public int HashKey(string key)
    {
        return key.GetHashCode();
    }
    
    public void Set(string key, T value)
    {
        int hash = HashKey(key);
        List<Entry<T>>? bucket = _table[hash % _table.Length];
        if (bucket == null)
        {
            bucket = new List<Entry<T>>();
            _table[hash % _table.Length] = bucket;    
        }

        for (int ix = 0; ix < bucket.Count; ix++)
        {
            Entry<T> entries = bucket[ix];
            if (entries.Key == key)
            {
                bucket.RemoveAt(ix);
                break;
            }
        }
        
        bucket.Add(new Entry<T>(key, value));
    }

    public T Get(string key)
    {
        int hash = HashKey(key);
        List<Entry<T>>? bucket = _table[hash % _table.Length];
        if (bucket == null)
        {
            throw new KeyNotFoundException();
        }
        
        foreach (Entry<T> entry in bucket)
        {
            if (entry.Key == key)
            {
                return entry.Value;
            }
        }
        throw new KeyNotFoundException();
    }

}
