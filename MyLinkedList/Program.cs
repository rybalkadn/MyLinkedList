using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTestList(new SingleLinkedList<string>());

            Console.ReadKey();
        }
        private static void DoTestList(ILinkedList<string> LinkedList)
        {
            LinkedList.AddToBegin("a1");
            LinkedList.AddToBegin("a2");
            LinkedList.AddToBegin("a3");
            LinkedList.AddToBegin("a4");
            LinkedList.AddToBegin("a5");

            LinkedList.Print();
            Console.WriteLine();

            LinkedList.AddToEnd("a1");
            LinkedList.AddToEnd("a2");
            LinkedList.AddToEnd("a3");
            LinkedList.AddToEnd("a4");
            LinkedList.AddToEnd("a5");

            LinkedList.Print();
            Console.WriteLine();

            string RemoveFirst = LinkedList.RemoveFirst();
            Console.WriteLine("Remove First: {0}", RemoveFirst);

            LinkedList.Print();


            Console.WriteLine();

            string RemoveEnd = LinkedList.RemoveEnd();
            Console.WriteLine("Remove End: {0}", RemoveEnd);

            LinkedList.Print();

            Console.WriteLine();

        }
    }
}
