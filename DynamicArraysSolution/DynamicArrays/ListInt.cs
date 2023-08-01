namespace CaptainCoder.DynamicArrays;
public class ListInt
{
    public const int DEFAULT_SIZE = 4;
    private int[] _data = new int[DEFAULT_SIZE];

    /// <summary>
    /// The number of integers inside of this list
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Retrieves the data stored at the specified <paramref name="index"/>.
    /// </summary>
    public int Get(int index)
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
    public void Set(int index, int value)
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
    public void Add(int value)
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
    public int Remove(int index)
    {
        if (index < 0 || index > Count - 1)
        {
            throw new IndexOutOfRangeException();
        }
        // Retrieve the value
        int value = _data[index];
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
        int[] newDataArray = new int[_data.Length*2];
        // 2. Copy old values
        for (int ix = 0; ix < _data.Length; ix++)
        {
            newDataArray[ix] = _data[ix];
        }
        _data = newDataArray;
    }
    
}