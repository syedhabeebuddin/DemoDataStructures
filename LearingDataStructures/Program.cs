using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearingDataStructures
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node { Value = 3 };
            Node middle = new Node { Value = 7 };
            first.Next = middle;

            Node last = new Node { Value = 9 };
            middle.Next = last;

            PrintList(first);

            Console.Read();
        }

        private static void PrintList(Node first)
        {
            while(first != null)
            {
                Console.Write(first.Value.ToString());
                Console.Write("-->");
                first = first.Next;
            }

            Console.Write("null");
        }
    }
}
