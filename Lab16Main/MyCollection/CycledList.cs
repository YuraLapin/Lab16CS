namespace Lab16Main
{
    [Serializable]
    public class Node<T>
    {
        public Node<T>? Prev;
        public Node<T>? Next;
        public T? Data;

        public Node()
        {
            Prev = null;
            Next = null;
            Data = default;
        }
    }

    [Serializable]
    public class CycledList<T> : IEnumerable<T>, ICollection<T> where T : ICloneable<T>, new()
    {
        public Node<T>? Start = null;

        public int Count
        {
            get;
            private set;
        }
        public bool IsReadOnly
        {
            get;
            set;
        }

        public virtual T? this[int index]
        {
            get
            {
                if (Start != null)
                {
                    var curNode = Start;
                    for (int i = 0; i < index; ++i)
                    {
                        if (curNode.Next == null || curNode.Prev == null)
                        {
                            return default;
                        }
                        curNode = curNode.Next;
                    }
                    if (curNode == null)
                    {
                        return default;
                    }
                    return curNode.Data;
                }
                return default;
            }
            set
            {
                if (Start != null)
                {
                    var curNode = Start;
                    for (int i = 0; i < index; ++i)
                    {
                        if (curNode != null)
                        {
                            if (curNode.Next != null || curNode.Prev != null)
                            {
                                curNode = curNode.Next;
                            }
                        }
                    }
                    if (curNode != null)
                    {
                        curNode.Data = value;
                    }
                }
            }
        }

        public CycledList()
        {
            Start = null;
            Count = 0;
        }

        public CycledList(int size)
        {
            Start = null;
            Count = 0;
            for (int i = 0; i < size; ++i)
            {
                Add(default);
            }
        }

        public CycledList(CycledList<T> anotherList)
        {
            foreach (T element in anotherList)
            {
                Add(element.Clone());
            }
            IsReadOnly = anotherList.IsReadOnly;
        }

        public void SetTo(CycledList<T> anotherList)
        {
            Clear();
            foreach (T element in anotherList)
            {
                Add(element.Clone());
            }
            IsReadOnly = anotherList.IsReadOnly;
        }

        public virtual void Add(T? element)
        {
            if (IsReadOnly)
            {
                return;
            }
            if (element != null)
            {
                if (Start == null)
                {
                    Count = 1;
                    Start = new Node<T>();
                    Start.Next = Start;
                    Start.Prev = Start;
                }
                else
                {
                    ++Count;
                    var newNode = new Node<T>();
                    newNode.Next = Start;
                    newNode.Prev = Start.Prev;
                    Start.Prev.Next = newNode;
                    Start.Prev = newNode;
                    Start = newNode;
                }
                if (element is T temp)
                {
                    Start.Data = element.Clone();
                }
                else
                {
                    Start.Data = element.Clone();
                }
            }
            else
            {
                if (Start != null)
                {
                    Start.Data = default;
                }
                else
                {
                    Start = new Node<T>();
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("[\r\n");
            foreach (T t in this)
            {
                sb.Append(t.ToString() + "\r\n");
            }
            if (Count == 0)
            {
                sb.Append("-\r\n");
            }
           sb.Append("]");
            return sb.ToString();
        }

        public void PrintTo(IPrinter<T> printer, Stream stream)
        {
            printer.Print(this, stream);
        }        

        public void ReadFrom(IReader<T> reader, Stream stream)
        {
            SetTo(reader.Read(this, stream));
        }        

        public IEnumerator<T> GetEnumerator()
        {
            if (Start != null)
            {
                var curNode = Start;
                for (int i = 0; i < Count; ++i)
                {
                    yield return curNode.Data;
                    curNode = curNode.Next;
                }
            }
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Clear()
        {
            if (IsReadOnly)
            {
                return;
            }
            if (Start != null)
            {
                for (int i = 0; i < Count - 1; ++i)
                {
                    Start.Next.Prev = Start.Prev;
                    Start.Prev.Next = Start.Next;
                    Start = Start.Next;
                }
                Count = 0;
                Start.Next = null;
                Start.Prev = null;
                Start = null;
            }
        }

        public bool Contains(T toFind)
        {
            if (Start == null)
            {
                return false;
            }
            foreach (T element in this)
            {
                if (element.Equals(toFind))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] arr, int start)
        {
            if (Count + start <= arr.GetLength(0))
            {
                int i = start;
                foreach (T element in this)
                {
                    arr[i] = element.Clone();
                    ++i;
                }
            }
        }

        public bool Remove(T t)
        {
            if (IsReadOnly)
            {
                return false;
            }

            if (Start == null)
            {
                return false;
            }

            if (!Contains(t))
            {
                return false;
            }

            var curNode = Start;
            int i = 0;
            while (!curNode.Data.Equals(t))
            {
                curNode = curNode.Next;
                ++i;
            }
            if (i == 0)
            {
                Start = Start.Next;
            }
            curNode.Data = default;
            curNode.Next.Prev = curNode.Prev;
            curNode.Prev.Next = curNode.Next;
            --Count;

            return true;
        }        

        public void Clone(ref CycledList<T> list)
        {
            list = new CycledList<T>(this);
        }

        public void ShallowCopy(ref CycledList<T> list)
        {
            list.Start = Start;
            list.Count = Count;
            list.IsReadOnly = IsReadOnly;
        }
    }
}