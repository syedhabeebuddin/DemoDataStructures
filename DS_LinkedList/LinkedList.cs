using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_LinkedList
{
    public class LinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }


        public int Count
        {
            get; private set;
        }

        public bool IsReadOnly { get; private set; }

        public void Add(T item)
        {
            LinkedListNode<T> current = new LinkedListNode<T>(item);
            if(Count ==0)
            {
                Head = Tail = current;
            }
            else
            {
                Tail.Next = current;
                Tail = current;
            }

            Count++;
        }

        public void Clear()
        {
            this.Head = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            bool isFound = false;
            LinkedListNode<T> current = Head;
            while(current != null)
            {
                if (current.Value.Equals(item))
                {
                    isFound = true;                   
                }
                else
                    current = current.Next;
            }

            return isFound;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = Head;
            while (current.Next != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current.Next != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {            
            LinkedListNode<T> current = Head;
            LinkedListNode<T> previous = null;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous == null)
                    {
                        Head = null;
                        Tail = null;
                        Count = 0;

                        return true;
                    }
                    else
                    {
                        previous.Next = current.Next;
                        //current = previous;
                        if(current.Next == null)
                        {
                            Tail = previous;
                        }

                        Count--;
                        return true;
                    }
                }                
                previous = current;
                current = current.Next;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while(current.Next != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        public void Print()
        {
            LinkedListNode<T> current = Head;
            while(current != null)
            {
                Console.Write(current.Value.ToString());
                Console.Write("-->");

                current = current.Next;
            }
        }
    }
}
