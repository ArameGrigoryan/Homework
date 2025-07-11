// using System.Diagnostics.CodeAnalysis;

// namespace Container;

// public class Stack<T> where T : struct
// {
//     public Vector<T> vec = null;
//     public int Size
//     {
//         get
//         {
//             return vec.Size;
//         }
//         set
//         {
//             vec.Capacity = value;
//         }
//     }

//     public Stack()
//     {
//         vec = new();
//         Size = 0;
//     }
//     private void Resize()
//     {
//         vec.Resize();
//     }
//     public void Push(T val)
//     {
//         if (Size == vec.Capacity)
//         {
//             Resize();
//         }
//         vec.PushBack(val);
//     }
//     public void Pop()
//     {
//         vec.PopBack();
//     }
//     public T Top()
//     {
//         if (Size == 0) { return default(T); }
//         return vec[Size - 1];
//     }
//     public void Empty()
//     {
//         vec.Resize(default(T), 0);
//     }
// }
