public class QueueLinkedList : IQueueImplementation
{

    public Node? start;
    public Node? frontPoint;
    public Node? rearPoint;
    public int count;
    public IQueueImplementation Dequeue()
    {
        if (start == null)
            throw new NullReferenceException(nameof(start.Priority));

        if (count == 1)
            start = null;

        else
            start = start.Next;

        --count;
        return this;
    }

    public IQueueImplementation Enqueue(int item)
    {
        rearPoint.Next= new(item);
        ++count;
        return this;
    }

    public IQueueImplementation EnqueuePriority(int priority)
    {
        Node newNode = new Node(priority);
        ++count;

        if (start == null)
            start = new Node(priority);


        else if (priority >= start.Priority)
        {
            newNode.Next = start;
            start = newNode;
        }
        else
        {
            Node tempNode = start;
            bool IsBigPro = false;
            while (tempNode.Next != null)
            {
                if (priority >= tempNode.Next.Priority)
                {
                    newNode.Next = tempNode.Next;
                    tempNode.Next = newNode;
                    IsBigPro = true;
                    tempNode = newNode.Next;
                    rearPoint = tempNode;
                }
                else
                { 
                    tempNode = tempNode.Next; 
                }
            }
            if (!IsBigPro)
            {
                tempNode.Next = newNode;
                rearPoint = newNode;
            }
        }
        frontPoint = start;
        return this;
    }

    public void Print()
    {
        Node temp = start;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(temp.Priority);
            temp = temp.Next;
        }
    }
}

