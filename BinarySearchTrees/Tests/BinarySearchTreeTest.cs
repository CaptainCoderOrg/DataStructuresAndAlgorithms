namespace Tests;
using Shouldly;

public class BinarySearchTreeTests
{
    [Fact]
    public void test_insert_one_item()
    { 
        // Triple AAA testing = Arrange, Act, Assert
        // Arrange
        BinarySearchTree tree = new BinarySearchTree();

        // Act
        tree.Insert('M').ShouldBeTrue();

        // Assert
        tree.Count.ShouldBe(1);
        tree.Contains('M').ShouldBeTrue();
        tree.Contains('B').ShouldBeFalse();

    }

        [Fact]
    public void test_insert_two_items()
    { 
        // Triple AAA testing = Arrange, Act, Assert
        // Arrange
        BinarySearchTree tree = new BinarySearchTree();

        // Act
        tree.Insert('M').ShouldBeTrue();
        tree.Insert('F').ShouldBeTrue();

        // Assert
        tree.Count.ShouldBe(2);
        tree.Contains('M').ShouldBeTrue();
        tree.Contains('F').ShouldBeTrue();
        tree.Contains('B').ShouldBeFalse();

    }

        [Fact]
    public void test_insert_three_items()
    { 
        // Triple AAA testing = Arrange, Act, Assert
        // Arrange
        BinarySearchTree tree = new BinarySearchTree();

        // Act
        tree.Insert('M').ShouldBeTrue();
        tree.Insert('F').ShouldBeTrue();
        tree.Insert('P').ShouldBeTrue();

        // Assert
        tree.Count.ShouldBe(3);
        tree.Contains('M').ShouldBeTrue();
        tree.Contains('F').ShouldBeTrue();
        tree.Contains('P').ShouldBeTrue();
        tree.Contains('B').ShouldBeFalse();

    }

    // [Fact]
    [Theory]
    [InlineData('M', 'F', 'P', 'A', 'L', 'Z', 'W', 'C', 'K', 'I')]
    [InlineData('B', 'E', 'F', 'O', 'R')]
    public void test_insert_many(params char[] letters)
    { 
        // Triple AAA testing = Arrange, Act, Assert
        // Arrange
        BinarySearchTree tree = new BinarySearchTree();

        // Act
        foreach (char ch in letters)
        {
            tree.Insert(ch);
        }

        // Assert
        tree.Count.ShouldBe(letters.Length);
        
        foreach (char ch in letters)
        {
            tree.Insert(ch).ShouldBe(false);
        }

        tree.Count.ShouldBe(letters.Length);
    }

    [Theory]
    [InlineData('M', 'F', 'P', 'A', 'L', 'Z', 'W', 'C', 'K', 'I')]
    [InlineData('B', 'E', 'F', 'O', 'R')]
    public void test_contains_many(params char[] letters)
    { 
        // Triple AAA testing = Arrange, Act, Assert
        // Arrange
        BinarySearchTree tree = new BinarySearchTree();

        // Act
        foreach (char ch in letters)
        {
            tree.Insert(ch);
        }

        // Assert
        foreach (char ch in letters)
        {
            tree.Contains(ch).ShouldBeTrue();
        }
    }

    [Theory]
    [InlineData('B', 'M', 'F', 'P', 'A', 'L', 'Z', 'W', 'C', 'K', 'I')]
    [InlineData('O', 'M', 'F', 'P', 'A', 'L', 'Z', 'W', 'C', 'K', 'I')]
    [InlineData('Q', 'M', 'F', 'P', 'A', 'L', 'Z', 'W', 'C', 'K', 'I')]
    [InlineData('X', 'M', 'F', 'P', 'A', 'L', 'Z', 'W', 'C', 'K', 'I')]
    public void test_does_not_contains_many(char toCheck, params char[] letters)
    { 
        // Triple AAA testing = Arrange, Act, Assert
        // Arrange
        BinarySearchTree tree = new BinarySearchTree();

        // Act
        foreach (char ch in letters)
        {
            tree.Insert(ch);
        }

        // Assert
        tree.Contains(toCheck).ShouldBeFalse();
    }
}