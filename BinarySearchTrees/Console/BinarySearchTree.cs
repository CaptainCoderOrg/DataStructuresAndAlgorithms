
// We are not going to allow duplicat entries
using System.Diagnostics;

public class BinarySearchTree
{
    private Node? _root;

    public int Count { get; private set; } = 0;
    public List<char> AllData => DataSet(_root, new List<char>());
    private List<char> DataSet(Node? _current, List<char> acc)
    {
        if (_current is null) { return acc; }
        acc.Add(_current.Data);
        DataSet(_current.LeftChild, acc);
        return DataSet(_current.RightChild, acc);
    }

    public bool Contains(char data) => RecursiveContains(data, _root);
    private bool RecursiveContains(char data, Node? currentNode)
    {
        if (currentNode is null) { return false; } // We did not find it
        if (currentNode.Data == data) { return true; } // We found it!
        // Keep looking left
        if (data < currentNode.Data)
        {
            return RecursiveContains(data, currentNode.LeftChild);
        }
        else // Keep looking to right
        {
            return RecursiveContains(data, currentNode.RightChild);
        }
        
    }

    public bool Insert(char data)
    {
        // If the tree is empty, make a root node
        if (_root is null)
        {
            _root = new Node(data);
            Count++;
            return true;
        }

        return RecursiveInsert(data, _root);
    }

    private bool RecursiveInsert(char data, Node currentNode)
    {
        Debug.Assert(currentNode is not null);
        if (data == currentNode.Data) { return false; }
        if (data < currentNode.Data)
        {
            if (currentNode.LeftChild is null)
            {
                currentNode.LeftChild = new Node(data);
                Count++;
                return true;
            }
            else
            {
                return RecursiveInsert(data, currentNode.LeftChild);
            }
        }
        else // data > currentNode.Data
        {
            if (currentNode.RightChild is null)
            {
                currentNode.RightChild = new Node(data);
                Count++;
                return true;
            }
            else
            {
                return RecursiveInsert(data, currentNode.RightChild);
            }
        }
    }

    

}