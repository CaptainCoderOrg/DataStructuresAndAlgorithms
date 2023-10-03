internal class BinarySearchNode
{
    public BinarySearchNode(char data)
    {
        Data = data;
    }
    public char Data { get; }
    public BinarySearchNode? LeftChild { get; set; }
    public BinarySearchNode? RightChild { get; set; }
    
}