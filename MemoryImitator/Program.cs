using System;
using System.Collections.Generic;
using Container;

class Program
{
    static void Main()
    {
        DoubleLinkedList<int> list = new DoubleLinkedList<int>();
        list.PushBack(5);
        list.PushBack(6);
        list.PushBack(7);
        list.PushBack(8);
        list.PushFront(4);
        list.Insert(9, 2);
        list.PopBack();
        list.Printf();
    }
}