using System.Collections;

namespace StackImplementation
{
    public class StackVector :IStackItems
    {
        private object[] stackVector;
        private int capacity;

        private int index;
        public int count;
        public int Count { get => count; }
        public object Current => stackVector[--index];
        public StackVector() : this(16) { }
        public StackVector(int capacity)
        {
            this.capacity = capacity;
            stackVector = new object[capacity];
        }
        public IStackItems Push(object data)
        {
            if (count < capacity)
            {
                stackVector[count++] = data;
            }
            else
            {
                capacity += 16;
                object[] newStackVector = new object[capacity];
                for (int i = 0; i < count; i++)
                {
                    newStackVector[i] = stackVector[i];
                }
                newStackVector[count++] = data;
                stackVector = newStackVector;
            }
            index = count;
            return this;
        }
        public void Print()
        {
            foreach (var item in this)
            {
                Console.WriteLine(item);
            }
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public bool MoveNext()
        {
            if (index > 0)
                return true;

            Reset();
            return false;
        }
        public void Reset()
        {
            index = count;
        }
        public IStackItems Pop()
        {
            stackVector[--count] = null;
            index = count;
            return this;
        }

        public object Peek()
        {
            try
            {
                return stackVector[--count];
            }
            finally
            {
                ++count;
                Pop();
            }
        }
    }
}
