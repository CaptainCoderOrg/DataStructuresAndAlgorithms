using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]


internal class Node
{
    public Node(char data)
    {
        Data = data;
    }
    public char Data { get; }
    public Node? LeftChild { get; set; }
    public Node? RightChild { get; set; }
    
    internal static void RotateLeft(Node center, Node joint)
    {
        center.LeftChild = joint;
        joint.RightChild = null;
    }

    internal static void RotateRight(Node center, Node joint)
    {
        center.RightChild = joint;
        joint.LeftChild = null;
    }

    internal static void RotateRightLeft(Node center, Node joint, Node parent)
    {

    }

    internal static void RotateLeftRight(Node center, Node joint, Node parent)
    {

    }

}