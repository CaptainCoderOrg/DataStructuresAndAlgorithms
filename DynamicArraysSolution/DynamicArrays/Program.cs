using CaptainCoder.DynamicArrays;
// See https://aka.ms/new-console-template for more information
DynamicArray<int> list = new DynamicArray<int>();
list.Add(10);
Console.WriteLine(list.Count);
Console.WriteLine(list[0]);
list[0] = 5;


list.Add(7);
Console.WriteLine(list.Count);
Console.WriteLine(list.Get(1));

list.Add(9);
Console.WriteLine(list.Count);
Console.WriteLine(list.Get(2));

list.Add(4);
Console.WriteLine(list.Count);
Console.WriteLine(list.Get(3));
