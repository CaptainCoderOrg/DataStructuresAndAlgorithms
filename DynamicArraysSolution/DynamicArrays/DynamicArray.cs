namespace CaptainCoder.DynamicArrays;

public class DynamicArray<T>
{
    public const int DEFAULT_SIZE = 4;
    private T[] _data = new T[DEFAULT_SIZE];

    /// <summary>
    /// The number of integers inside of this list
    /// </summary>
    public int Count { get; private set; }

    public T this[int index] 
    {
        get => Get(index);
        set => Set(index, value);
    }

    /// <summary>
    /// Retrieves the data stored at the specified <paramref name="index"/>.
    /// </summary>
    public T Get(int index)
    {
        // list[index]
        if (index < 0 || index > Count - 1)
        {
            throw new IndexOutOfRangeException();
        }
        return _data[index];
    }

    /// <summary>
    /// Sets the data stored at the specified <paramref name="index"/> to be the
    /// specified <paramref name="value"/>.
    /// </summary>
    public void Set(int index, T value)
    {
        // list[index] = value;
        if (index < 0 || index > Count - 1)
        {
            throw new IndexOutOfRangeException();
        }
        _data[index] = value;
    }

    /// <summary>
    /// Adds and stores the specified <paramref name="value"/> at the end of the
    /// list.
    /// </summary>
    public void Add(T value)
    {
        // Check for resize
        if (Count == _data.Length)
        {
            Resize();
        }
        _data[Count] = value;
        Count++;
    }

    /// <summary>
    /// Removes the data stored at the specified index and returns it.
    /// </summary>
    public T Remove(int index)
    {
        if (index < 0 || index > Count - 1)
        {
            throw new IndexOutOfRangeException();
        }
        // Retrieve the value
        T value = _data[index];
        // Remove the value (shift values as necessary)
        for (int ix = index; ix < Count - 1; ix++)
        {
            _data[ix] = _data[ix + 1];
        }
        // Decrease the count by 1
        Count--;
        return value;
    }

    private void Resize()
    {
        // 1. Double the size
        T[] newDataArray = new T[_data.Length * 2];
        // 2. Copy old values
        for (int ix = 0; ix < _data.Length; ix++)
        {
            newDataArray[ix] = _data[ix];
        }
        _data = newDataArray;
    }
}