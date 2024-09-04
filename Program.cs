namespace Stack
{
    public class ArrStack<T>
    {
        private T[] elements;
        public int Count { get; private set; }
        private const int InitialCapacity = 16;
        public ArrStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
            this.Count = Count;
        }
        public void Push(T element)
        {
            if (this.Count == this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.Count] = element;
            this.Count++;
        }
        private void Grow()
        {
            T[] NewElements = new T[2 * this.elements.Length];
            for (int i = 0; i < this.Count; i++)
            {
                NewElements[i] = this.elements[i];
            }
            elements = NewElements;
        }
        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            this.Count--;
            return this.elements[this.Count];
        }
        public T[] ToArray ()
        {
            T [] arr = new T[this.Count];
            for (int i = 0;i < this.Count;i++)
            {
                arr[i]= this.elements[i];
            }
            return arr;
        }
    }
}