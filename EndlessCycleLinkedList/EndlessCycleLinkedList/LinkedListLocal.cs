namespace EndlessCycleLinkedList
{
    public class LinkedListLocal<T>
    {
        public Node<T> head;
        private int count = 0;
        public int Length { get => count; }

        private HashSet<Node<T>> set;
        private Node<T> slow;
        private Node<T> fast;
        public LinkedListLocal()
        {
            set = new HashSet<Node<T>>();
        }
        public LinkedListLocal<T> Add(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                ++count;
            }
            else
            {
                Node<T> tempNode = head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = new(data);
                ++count;
            }
            return this;
        }
        public void PrintData()
        {
            if (head == null)
                throw new NullReferenceException("You don't have data!");

            Node<T> tempNode = head;
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.data);
                tempNode = tempNode.next;
            }
        }

        public bool IsCycle()
        {
            this.slow = head;
            this.fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }
            return false;
        }
        public object? CycleData()
        {
            if (IsCycle())
            {
                slow = head;
                while (slow != fast)
                {
                    slow = slow.next;
                    fast = fast.next;
                }
                return slow.data;
            }
            return "Don't found";
        }
        public bool IsCycleWithHashSet()
        {
            Node<T> tempNodeSet = head;

            while (tempNodeSet != null)
            {
                if (set.Contains(tempNodeSet.next))
                    return true;

                set.Add(tempNodeSet);
                tempNodeSet = tempNodeSet.next;
            }
            return false;
        }
    }
}
