namespace Tests;
using Shouldly;

public class NodeRotationTests
{
    [Fact]
    public void test_left_rotation()
    { 
        // Triple A testing (Arrange, Act, Assert)
        // Arrange
        Node a = new Node('A');
        Node b = new Node('B');
        Node c = new Node('C');
        a.RightChild = b;
        b.RightChild = c;
        
        // Act
        Node.RotateLeft(b, a);

        // Assert
        a.LeftChild.ShouldBeNull();
        a.RightChild.ShouldBeNull();
        b.LeftChild.ShouldBe(a);
        b.RightChild.ShouldBe(c);
        c.LeftChild.ShouldBeNull();
        c.RightChild.ShouldBeNull();
    }

    [Fact]
    public void test_right_rotation()
    {
        // Triple A testing (Arrange, Act, Assert)
        // Arrange
        Node a = new Node('A');
        Node b = new Node('B');
        Node c = new Node('C');
        c.LeftChild = b;
        b.LeftChild = a;
        
        // Act
        Node.RotateRight(b, c);

        // Assert
        a.LeftChild.ShouldBeNull();
        a.RightChild.ShouldBeNull();
        b.LeftChild.ShouldBe(a);
        b.RightChild.ShouldBe(c);
        c.LeftChild.ShouldBeNull();
        c.RightChild.ShouldBeNull();            
    }

    [Fact]
    public void test_right_left_rotation()
    {
        // Triple A testing (Arrange, Act, Assert)
        // Arrange
        Node a = new Node('A');
        Node b = new Node('B');
        Node c = new Node('C');
        a.RightChild = c;
        c.LeftChild = b;
        
        // Act
        Node.RotateRightLeft(b, c);

        // Assert
        a.LeftChild.ShouldBeNull();
        a.RightChild.ShouldBeNull();
        b.LeftChild.ShouldBe(a);
        b.RightChild.ShouldBe(c);
        c.LeftChild.ShouldBeNull();
        c.RightChild.ShouldBeNull();            
    }
}