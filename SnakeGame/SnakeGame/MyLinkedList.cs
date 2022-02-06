using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class MyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; } = 0;
        public bool IsReversed { get; set; } = false;
        public void AddFirst(T newNode)
        {
            Node<T> node = new Node<T>(newNode);

            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Previous = node;
                Head = node;
            }

            Count++;
        }
        public void AddLast(T newNode)
        {
            Node<T> node = new Node<T>(newNode);

            if (Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }

            Count++;
        }
        public T RemoveFirst()
        {
            if (Count == 0)
                throw new ArgumentNullException("The list is empty!");

            T headValue = Head.Value;

            if (Head.Next != null)
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            else
            {
                Head = null;
                Tail = null;
            }
            Count--;

            return headValue;
        }
        public T RemoveLast()
        {
            if (Count == 0)
                throw new ArgumentNullException("The list is empty!");

            T tailValue = Tail.Value;

            if (Tail.Previous != null)
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            else
            {
                Head = null;
                Tail = null;
            }
            Count--;

            return tailValue;
        }
        public void ForEach(Action<T> action)
        {
            Node<T> currentNode = null;
            if (!IsReversed)
                currentNode = Head;
            else
                currentNode = Tail;

            while (currentNode != null)
            {
                action(currentNode.Value);

                if (!IsReversed)
                    currentNode = currentNode.Next;
                else
                    currentNode = currentNode.Previous;
            }
        }
        public T[] ToArray()
        {
            if (Count == 0)
                throw new ArgumentNullException("The list is empty!");

            var arr = new T[Count];
            int index = 0;

            var currentNode = Head;
            while (currentNode != null)
            {
                arr[index] = currentNode.Value;
                currentNode = currentNode.Next;
                index++;
            }
            return arr;
        }
        public void Reverse()
        {
            IsReversed = !IsReversed;
        }
    }
}
