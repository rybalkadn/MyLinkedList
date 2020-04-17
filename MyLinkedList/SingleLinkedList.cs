using System;
using System.Collections;
using System.Collections.Generic;

namespace MyLinkedList
{
    class SingleLinkedList<T> :  ILinkedList<T>
    {
        private Node _first = null;
        private Node _last = null;
        private Node _current = null;

        public bool IsEmpty()
        {
            return (_first == null);
        }

        public void AddToEnd(T item)
        {
            Node newNode = new Node();

            if (IsEmpty())
            {
                _last = newNode;
            }
            else
            {
                 _current = _first;
                while (_current.Next != null)
                {
                    _current = _current.Next;
                }
                newNode.Info = item;
                _current.Next = newNode;
            }
        }

        public void AddToBegin(T item)
        {

            Node newNode = new Node
            {
                Info = item,
                Next = _first
            };

            _first = newNode;
        }
        public T RemoveFirst()
        {
            if (!IsEmpty())
            {
                _current = _first;
                _current = _current.Next;
                _first = _current;
            }

            return _first.Info;
        }

        public T RemoveEnd()
        {
            if (IsEmpty())
            {
                //ToDo:
                throw new Exception();
            }            

            T result = default(T);    // null - ref.types, 0 - value types

            if (_first.Next == null)    // один элемент в списке
            {
                result = _first.Info;
                _first = null;
                _last = null;
            }
            else
            {
                // ищем сслку на предпоследний элемент
                Node current = _first;

                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                result = current.Next.Info;
                current.Next = null;
                _last = current;
            }


           

            return result;
        }


        public void Print()
        {
            _current = _first;

            while (_current != null)
            {
                Console.Write("{0}\t", _current.Info);

                _current = _current.Next;
            }
            Console.WriteLine();
        }

      

  
        private class Node
        {
            public T Info { get; set; }    // Информационная часть
            public Node Next { get; set; }    // Ссылка на следующий элемент списка
        }
    }
}
