using StackImplementation;
using System.Collections;
using System.Runtime.CompilerServices;

public class StackLinkedList :IStackItems
{
    public Node? start;
    private Node? tempNode;
    private int count;
    public int Count { get => count; }
    public object Current
    {
        get
        {
            try
            {
                return tempNode.data;
            }
            finally
            {
                tempNode=tempNode.next;
            }         
        }
    }
    public IStackItems Push(object data)
    {
        Node newNode = new Node(data);
        if (start == null)
        {
            start = newNode;
            ++count;
        }
        else
        {
            newNode.next = start;
            start = newNode;
            tempNode = start;
            ++count;
        }
        return this;
    }
    public void Print()
    {
        foreach (var node in this)
        {
            Console.WriteLine(node);            
        }
    }
    public IEnumerator GetEnumerator()
    {
        return this;
    }
    public bool MoveNext()
    {
        if (tempNode != null)
        {
            return true;
        }
        Reset();
        return false;
    }
    public void Reset()
    {
        tempNode = start;
    }

    public IStackItems Pop()
    {
        if(count==1)
        {
            start = null;
            --count;
        }
        else
        {
            start = start.next;
            tempNode = start;
            --count;
        }
        return this;
    }

    public object Peek()
    {
        try
        {
            return start.data;
        }
        finally
        {
            Pop();
        }

    }
}

