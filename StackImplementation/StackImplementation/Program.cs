using StackImplementation;

  
StackVector stack= new StackVector(); 
//StackLinkedList stack = new StackLinkedList();
stack.Push(5).Push(2).Push(6).Push(6).Push(9);
//stack.Pop();    
//Console.WriteLine(stack.start.data+" "+ stack.start.next.data);
Console.WriteLine(stack.Peek());
stack.Print();


