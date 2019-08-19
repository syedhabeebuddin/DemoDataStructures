using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode<int> list = new LinkedListNode<int>(1);
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            Console.WriteLine("Head : " + myList.Head.Value.ToString());
            Console.WriteLine("Tail: " + myList.Tail.Value);
            Console.WriteLine("Count : " + myList.Count);            

            myList.Print();
            //Console.Read();

            myList.Remove(3);


            Console.WriteLine("Head : " + myList.Head.Value.ToString());
            Console.WriteLine("Tail: " + myList.Tail.Value);
            Console.WriteLine("Count : " + myList.Count);

            myList.Print();
            Console.Read();
        }
    }
}
