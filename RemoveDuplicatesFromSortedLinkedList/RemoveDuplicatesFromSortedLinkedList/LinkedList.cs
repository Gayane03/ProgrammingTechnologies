using System.Collections;

public class LinkedList
{
    public Node? head;
    private int count = 0;
    public int Length { get => count; }
    public LinkedList Add(object data)
    {
        if(head==null)
        {
            head = new Node(data);   
            ++count;
        }
        else
        {
            Node tempNode = head;
            while(tempNode.next != null)
            {
                tempNode = tempNode.next;
            }
            tempNode.next = new Node(data);
            ++count;
        }
        return this;
    }
    public LinkedList Delete(ref Node item)
    {
        if (item.next == null)
        { 
            item = null;
            --count;
        }
        else
        {
            item.data = item.next.data;
            item.next = item.next.next;
            --count;
        }
        return this;        
    }
    public void RemoveDuplicates()
    {
        Node? temp = head;
        while (temp != null && temp.next != null)
        {
            if(Equals(temp.next.data,temp.data))            
                Delete(ref temp);

            temp = temp.next;
        }
    }
    public void PrintNodesData()
    {
        if (head is null)
            throw new NullReferenceException("You don't have instance of Node!");

        Node temp = head;
        while (temp!=null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }
}

