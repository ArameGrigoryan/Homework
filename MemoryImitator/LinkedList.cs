using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Collections.Generic;
using System;

public class LinkedList<T> where T : IComparable<T>
{
    public class Node
    {
        public T value { get; set; }
        public Node next { get; set; }
        public Node(T val)
        {
            value = val;
        }
    }
    Node head = new Node(default(T));

    public void PushBack(T val)
    {
        Node ptr = head;
        while (ptr != null && ptr.next != null)
        {
            ptr = ptr.next;
        }
        ptr.next = new Node(val);
    }
    public void PopBack()
    {
        Node ptr = head;
        while (ptr.next != null && ptr.next.next != null)
        {
            ptr = ptr.next;
        }
        if (ptr.next == null) { return; }

        ptr.next.next = null;
    }
    public void PushFront(T val)
    {
        Node tmp = new Node(val);
        tmp.next = head.next;
        head.next = tmp;
    }
    public void PopFront()
    {
        if (head.next == null) { return; }
        head.next = head.next.next;
    }
    public void Insert(int pos, T val)
    {
        --pos;
        Node ptr = head;
        while (pos > 0)
        {
            ptr = ptr.next;
            --pos;
        }
        Node tmp = new Node(val);
        tmp.next = ptr.next;
        ptr.next = tmp;
    }
    public void Erase()
    {
        head.next = null;
    }
    public void PrintList()
    {
        if (head.next == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        Node ptr = head.next;
        while (ptr != null)
        {
            Console.Write(ptr.value + " ");
            ptr = ptr.next;
        }
        Console.WriteLine();
    }
    public Node GetMidElement()
    {
        Node secnd = head;
        Node first = head;
        while (first != null && first.next != null)
        {
            first = first.next.next;
            secnd = secnd.next;
        }
        return secnd;
    }
    public void MergSort()
    {
        head.next = MergSort(head.next);
    }
    private Node MergSort(Node list)
    {
        if (list == null || list.next == null) { return list; }
        Node mid = GetMid(list);
        Node list2 = mid.next;
        mid.next = null;
        Node res1 = MergSort(list);
        Node res2 = MergSort(list2);
        return Merg(res1, res2);
    }
    public Node Merg(Node list1, Node list2)
    {
        if (list1 == null) { return list2; }
        else if (list2 == null) { return list1; }

        if (list1.value.CompareTo(list2.value) <= 0)
        {
            list1.next = Merg(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = Merg(list1, list2.next);
            return list2;
        }
    }
    private Node GetMid(Node list)
    {
        Node secnd = list;
        Node first = list.next;
        while (first != null && first.next != null)
        {
            first = first.next.next;
            secnd = secnd.next;
        }
        return secnd;
    }
}