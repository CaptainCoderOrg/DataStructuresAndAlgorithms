using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Tests")]

namespace CaptainCoder.Collections;


public class DoublyLinkedList<T>
{
    internal Node? _head;
    internal Node? _tail;
    public int Count { get; private set; }

    /// <summary>
    /// Adds the specified element to the end of this list.
    /// </summary>
    public void Add(T element)
    {
        if (Count == 0)
        {
            _head = new Node(element);
            _tail = _head;
        }
        else
        {
            Node prevTail = _tail!;
            _tail = new Node(element);
            _tail._prev = prevTail;
            prevTail._next = _tail;
        }
        Count++;
    }

    /// <summary>
    /// Retrieves the element at the specified <paramref name="index"/>
    /// </summary>
    public T Get(int index) => GetNode(index)._data;

    /// <summary>
    /// Sets the value at the specified index to the be the specified element
    /// </summary>
    public void Set(int index, T element) => GetNode(index)._data = element;

    /// <summary>
    /// Removes the element at the specified <paramref name="index"/> and returns it.
    /// </summary>
    public T Remove(int index)
    {
        Node toRemove = GetNode(index);
        
        // Last Element is being removed
        if (toRemove._prev is null && toRemove._next is null)
        {
            _head = null;
            _tail = null;
            Count = 0;
            return toRemove._data;
        }

        // Head Case (with at least 2 elements)
        if (toRemove._prev is null)
        {
            _head = _head!._next;
            _head!._prev = null;
            Count--;
            return toRemove._data;
        }

        // Tail Case (with at least 2 elements)
        if (toRemove._next is null)
        {
            _tail = toRemove._prev;
            _tail._next = null;
            Count--;
            return toRemove._data;
        }

        // Remove from middle

        toRemove._prev._next = toRemove._next;
        toRemove._next._prev = toRemove._prev;
        Count--;
        
        return toRemove._data;
    }

    private Node GetNode(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException();
        }
        Node current = _head!;
        while (index > 0)
        {
            current = current._next!;
            index--;
        }
        return current;
    }    

    

    internal class Node
    {
        internal T _data;
        internal Node? _next;
        internal Node? _prev;

        internal Node(T data)
        {
            _data = data;
        }

        internal T Get(int index)
        {
            if (index == 0)
            {
                return _data;
            }
            return _next!.Get(index - 1);
        }
    }
}