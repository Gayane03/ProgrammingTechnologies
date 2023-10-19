
public interface IQueueImplementation
{
    public IQueueImplementation EnqueuePriority(int item);
    public IQueueImplementation Enqueue(int item);

    public IQueueImplementation Dequeue();
    public void Print();

}

