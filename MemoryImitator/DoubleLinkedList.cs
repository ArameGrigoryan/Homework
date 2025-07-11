using System;
namespace Container;

public class DoubleLinkedList<T>
{
    class Node
    {
        public Node next = null;
        public Node prev = null;
        public T val;
        public Node(T val)
        {
            this.val = val;
        }
    }
    Node list1 = new(default(T));
    Node list2 = new(default(T));
    public void PushBack(T val)
    {
        Node newNode = new(val);

        if (list1.next == null)
        {
            list1.next = newNode;
            list2.prev = newNode;
            newNode.next = list2;
            newNode.prev = list2;
        }
        else
        {
            Node tmp = list2.prev;
            list2.prev = newNode;
            tmp.next = newNode;
            newNode.next = list2;
            newNode.prev = tmp;
        }
    }
    public void PopBack()
    {
        if (list1.next == list2) { return; }
        Node ptr = list1;
        while (ptr.next.next != list2)
        {
            ptr = ptr.next;
        }
        ptr.next = list2;
        list2.prev = ptr;
    }
    public void PushFront(T val)
    {
        Node newNode = new(val);

        if (list1.next == null)
        {
            list1.next = newNode;
            list2.prev = newNode;
            newNode.next = list2;
            newNode.prev = list2;
        }
        else
        {
            Node tmp = list1.next;
            list1.next = newNode;
            tmp.prev = newNode;
            newNode.prev = list1;
            newNode.next = tmp;
        }
    }
    public void PopFront()
    {
        if (list1.next == null) { return; }

        Node tmp = list1.next.next;
        list1.next = tmp;
        tmp.prev = list1;
    }
    public void Insert(T val, int pos)
    {
        Node ptr = list1;
        while (pos > 0 && ptr != null)
        {
            ptr = ptr.next;
            --pos;
        }
        if (pos > 0)
        {
            PushBack(val);
            return;
        }
        Node ptr2 = ptr.next;
        Node elem = new(val);
        ptr.next = elem;
        ptr2.prev = elem;
        elem.prev = ptr;
        elem.next = ptr2;
    }
    public void Erase()
    {
        list1.next = null;
        list2.prev = null;
    }
    public void Printf()
    {
        if (list1.next == null) { return; }

        Node ptr = list1.next;
        while (ptr != list2)
        {
            Console.WriteLine(ptr.val);
            ptr = ptr.next;
        }
    }
}
