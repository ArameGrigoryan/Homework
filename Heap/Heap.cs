namespace Heap;

public class Heap
{
    private List<int> nums = null;
    private int _size = 0;
    public int Size => _size;

    public Heap()
    {
        nums = new List<int>();
    }
    private int GetLeft(int i) => i * 2 + 1;
    private int GetRight(int i) => i * 2 + 2;
    private int GetParent(int i) => (i - 1) / 2;

    private void Swap(int i, int j)
    {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }
    private bool HaseParent(int i) => GetParetn(i) >= 0;
    public void HeapifyMax(int index)
    {
        int left = GetLeft(index);
        int right = GetRight(index);
        int largest = index;

        if (left < _size && nums[left] > nums[largest])
        {
            largest = left;
        }
        if (right < _size && nums[right] > nums[largest])
        {
            largest = right;
        }
        if (largest != i)
        {
            Swap(largest, i);
            HeapifyMax(largest);
        }
    }
    public void HeapifyMin(int index)
    {
        int left = GetLeft(index);
        int right = GetRight(index);
        int largest = index;
        if (left < _size && nums[left] < nums[largest])
        {
            largest = left;
        }
        if (right < _size && nums[right] < nums[largest])
        {
            largest = right;
        }
        if (largest != index)
        {
            Swap(largest, index);
            HeapifyMin(largest);
        }
    }
    public void HeapifyUp(int index)
    {
        while (HaseParent(index) == true && nums[index] > nums[GetParent(index)])
        {
            Swap(index, GetParent(index));
            index = GetParent(index);
        }
    }
    public int ExtractMax()
    {
        int max = nums[0];
        nums[0] = nums[_size - 1];
        nums.RemoveAt(_size - 1);
        Heapify(0);
    }
    public void Insert(int val)
    {
        nums.Add(val);
        ++_size;
        HeapifyUp(_size - 1);
    }
    public int Peek()
    {
        return nums[0];
    }
    public void Build()
    {
        for (int i = GetParent(arr.Length); i >= 0; --i)
        {
            HeapifyMax(i);
        }
    }
}