using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework1
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> First { get; set; }

        public bool IsEmpty()
        {
            return First == null;
        }
        public void AddToHead(T x)
        {
            LinkedListNode<T> temp = new LinkedListNode<T>();
            temp.Data = x;
            temp.Next = First;
            First = temp;
        }
        public void AddToTail(T x)
        {
            LinkedListNode<T> temp = new LinkedListNode<T>();
            temp.Data = x;
            if (IsEmpty())
            {
                First = temp;
            }
            else
            {
                LinkedListNode<T> temp2 = First;
                while (temp2.Next != null)
                {
                    temp2 = temp2.Next;
                }
                temp2.Next = temp;
            }
        }

        public int Find(T dataToFind)
        {
            LinkedListNode<T> tmp = First;
            int indx = 0;
            while (tmp != null)
            {
                if (tmp.Data.Equals(dataToFind))
                {
                    return indx;
                }
                tmp = tmp.Next;
                indx++;
            }
            return -1;
        }
    }
}
