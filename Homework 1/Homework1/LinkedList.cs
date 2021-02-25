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
    }
}
