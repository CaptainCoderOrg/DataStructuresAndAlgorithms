using CaptainCoder.Collections;
using Shouldly;
namespace Tests;

public class ListIntTest
{
    [Fact]
    public void TestAddEmpty()
    {
        // Pre-conditions
        var list = new DoublyLinkedList<int>();
        list.Count.ShouldBe(0);

        // Thing to be tested
        list.Add(10);

        // Post conditions
        list.Count.ShouldBe(1);
        list._head?._data.ShouldBe(10);
        list._tail?._data.ShouldBe(10);
        list._head.ShouldBe(list._tail);
    }

    [Fact]
    public void TestAddSecond()
    {
        // Pre-conditions
        var list = new DoublyLinkedList<int>();
        list.Add(10);

        // Thing to be tested
        list.Add(15);

        // Post conditions
        list.Count.ShouldBe(2);
        list._head?._data.ShouldBe(10);
        list._tail?._data.ShouldBe(15);
        list._head?._next?.ShouldBe(list._tail);
        list._tail?._prev?.ShouldBe(list._head);
    }

    [Fact]
    public void TestAddThird()
    {
        // Pre-conditions
        var list = new DoublyLinkedList<int>();
        list.Add(10);
        list.Add(15);

        // Thing to be tested
        list.Add(42);

        // Post conditions
        list.Count.ShouldBe(3);
        list._head?._data.ShouldBe(10);
        list._head?._next?._data.ShouldBe(15);
        list._tail?._data.ShouldBe(42);        
        list._head?._next?._next?.ShouldBe(list._tail);
        list._tail?._prev?._prev?.ShouldBe(list._head);
    }

    [Fact]
    public void TestCount()
    {
        var list = new DoublyLinkedList<int>();
        list.Count.ShouldBe(0);

        list.Add(10);
        list.Count.ShouldBe(1);

        list.Add(15);
        list.Count.ShouldBe(2);

        list.Add(4);
        list.Count.ShouldBe(3);

        list.Add(0);
        list.Count.ShouldBe(4);
    }

    [Fact]
    public void TestAddGet()
    {
        var list = new DoublyLinkedList<int>();
        list.Add(10);
        list.Get(0).ShouldBe(10);

        list.Add(5);
        list.Get(0).ShouldBe(10);
        list.Get(1).ShouldBe(5);

        list.Add(15);
        list.Get(0).ShouldBe(10);
        list.Get(1).ShouldBe(5);
        list.Get(2).ShouldBe(15);

        list.Add(4);
        list.Get(0).ShouldBe(10);
        list.Get(1).ShouldBe(5);
        list.Get(2).ShouldBe(15);
        list.Get(3).ShouldBe(4);

        list.Add(19);
        list.Get(0).ShouldBe(10);
        list.Get(1).ShouldBe(5);
        list.Get(2).ShouldBe(15);
        list.Get(3).ShouldBe(4);
        list.Get(4).ShouldBe(19);
    }

    [Fact]
    public void TestAddSet()
    {
        var list = new DoublyLinkedList<int>();
        list.Add(10);
        list.Add(5);
        list.Add(15);
        list.Add(4);
        list.Get(0).ShouldBe(10);
        list.Get(1).ShouldBe(5);
        list.Get(2).ShouldBe(15);
        list.Get(3).ShouldBe(4);

        list.Set(0, 7);
        list.Get(0).ShouldBe(7);
        list.Get(1).ShouldBe(5);
        list.Get(2).ShouldBe(15);
        list.Get(3).ShouldBe(4);

        list.Set(1, 0);
        list.Get(0).ShouldBe(7);
        list.Get(1).ShouldBe(0);
        list.Get(2).ShouldBe(15);
        list.Get(3).ShouldBe(4);

        list.Set(2, 3);
        list.Get(0).ShouldBe(7);
        list.Get(1).ShouldBe(0);
        list.Get(2).ShouldBe(3);
        list.Get(3).ShouldBe(4);

        list.Set(3, 0);
        list.Get(0).ShouldBe(7);
        list.Get(1).ShouldBe(0);
        list.Get(2).ShouldBe(3);
        list.Get(3).ShouldBe(0);
    }

    [Fact]
    public void TestRemoveFirst()
    {
        var list = new DoublyLinkedList<int>();
        list.Add(10);
        list.Add(5);
        list.Add(15);
        list.Add(4);

        list.Count.ShouldBe(4);
        list.Remove(0).ShouldBe(10);
        list.Count.ShouldBe(3);

        list.Remove(0).ShouldBe(5);
        list.Count.ShouldBe(2);

        list.Remove(0).ShouldBe(15);
        list.Count.ShouldBe(1);

        list.Remove(0).ShouldBe(4);
        list.Count.ShouldBe(0);
    }

    [Fact]
    public void TestRemoveMiddle()
    {
        var list = new DoublyLinkedList<int>();
        list.Add(10);
        list.Add(5);
        list.Add(15);
        list.Add(4);

        list.Count.ShouldBe(4);
        list.Remove(1).ShouldBe(5);
        list.Count.ShouldBe(3);

        list.Remove(2).ShouldBe(4);
        list.Count.ShouldBe(2);

        list.Remove(1).ShouldBe(15);
        list.Count.ShouldBe(1);

        list.Remove(0).ShouldBe(10);
        list.Count.ShouldBe(0);
    }
}