using System.Collections;

namespace StackImplementation
{
    public interface IStackItems:IEnumerable,IEnumerator
    {
        public int Count { get; }
        public IStackItems Push(object data);
        public void Print();
        public IStackItems Pop();
        public object Peek();
    }
}
