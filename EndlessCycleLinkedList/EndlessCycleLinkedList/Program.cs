using EndlessCycleLinkedList;

LinkedListLocal<int> list = new();

list.Add(5).Add(6).Add(7).Add(8);
list.head.next.next.next = list.head.next.next;

Console.WriteLine(list.IsCycleWithHashSet());
Console.WriteLine(list.IsCycle());
Console.WriteLine(list.CycleData());