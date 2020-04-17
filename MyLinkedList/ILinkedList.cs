using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    interface ILinkedList<T>
    {
        bool IsEmpty();
        void AddToBegin(T item);
        void AddToEnd(T item);
        T RemoveFirst();
        T RemoveEnd();
        void Print();
    }
}
