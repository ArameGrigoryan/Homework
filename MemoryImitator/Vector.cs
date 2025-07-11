// using System.ComponentModel;
// using System.Data.Common;
// using System.Collections;

// namespace Container;

// public class Vector<T> : IEnumerable<T> where T : struct
// {
//     private T[] arr { get; set; }
//     public int Capacity { get; set; }
//     public int Size { get; set; }
//     public Vector()
//     {
//         arr = new T[0];
//         Size = 0;
//         Capacity = 0;
//     }
//     public void Resize()
//     {
//         if (Capacity == 0)
//         {
//             arr = new T[1];
//             Capacity = 1;
//             return;
//         }
//         Capacity *= 2;
//         T[] tmp = new T[Capacity];
//         for (int i = 0; i < Size; ++i)
//         {
//             tmp[i] = arr[i];
//         }
//         arr = tmp;
//         return;
//     }
//     public void Resize(T val, int count)
//     {
//         if (count == 0)
//         {
//             arr = null;
//             Size = 0;
//             Capacity = 0;
//             return;
//         }
//         else if (count > Size)
//         {
//             count = Size;
//         }
//         T[] tmp = new T[count];
//         for (int i = 0; i < count; ++i)
//         {
//             tmp[i] = val;
//         }
//         arr = tmp;
//         Size = count;
//         Capacity = count;
//         return;
//     }
//     public void PushBack(T val)
//     {
//         if (Size == Capacity)
//         {
//             Resize();
//         }
//         arr[Size++] = val;
//     }
//     public void PushBack(T val, int count)
//     {
//         if (count <= 0) { return; }
//         while (Size + count > Capacity)
//         {
//             Resize();
//         }
//         int tmp = Size + count;
//         while (Size < tmp)
//         {
//             arr[Size++] = val;
//         }
//         return;
//     }
//     public void Insert(T val, int pos)
//     {
//         if (Size == Capacity) { Resize(); }

//         if (pos >= Size)
//         {
//             PushBack(val);
//             return;
//         }
//         else if (pos < 0) { pos = 0; }

//         for (int i = Size; i > pos; --i)
//         {
//             arr[i] = arr[i - 1];
//         }
//         arr[pos] = val;
//         ++Size;
//         return;
//     }
//     public void PopBack()
//     {
//         if (Size == 0) { return; }
//         --Size;
//     }
//     public void Erase(int pos)
//     {
//         if (pos > Size)
//         {
//             PopBack();
//             return;
//         }
//         else if (pos < 0) { pos = 0; }

//         for (int i = pos; i < Size - 1; ++i)
//         {
//             arr[i] = arr[i + 1];
//         }
//         --Size;
//         return;
//     }
//     public void Shrink()
//     {
//         if (Size == 0)
//         {
//             arr = new T[0];
//             Capacity = 0;
//             return;
//         }
//         T[] tmp = new T[Size];
//         for (int i = 0; i < Size; ++i)
//         {
//             tmp[i] = arr[i];
//         }
//         arr = tmp;
//         Capacity = Size;
//         return;
//     }
//     public void Clear()
//     {
//         for (int i = 0; i < Size; ++i)
//         {
//             arr[i] = default(T);
//         }
//         Size = 0;
//     }
//     public T this[int index]
//     {
//         get
//         {
//             if (index >= Size || index < 0) { throw new IndexOutOfRangeException("invalid index"); }
//             return arr[index];
//         }
//         set
//         {
//             if (index < 0 || index >= Size) { throw new IndexOutOfRangeException("invalid index"); }
//             arr[index] = value;
//         }
//     }
//     public IEnumerator<T> GetEnumerator()
//     {
//         for (int i = 0; i < Size; ++i)
//         {
//             yield return arr[i];
//         }
//     }
//     IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
// }
