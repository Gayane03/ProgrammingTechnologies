using System.Collections;


QueueLinkedList ob=new QueueLinkedList();
ob.EnqueuePriority(3).EnqueuePriority(10).EnqueuePriority(6).Enqueue(5);
//ob.Dequeue();
//Console.WriteLine(ob.rearPoint.Priority);
ob.Print();