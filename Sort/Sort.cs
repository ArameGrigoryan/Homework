namespace Sort;

public static class Sort
{
    public static void BubleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; ++i)
        {
            bool flag = true;
            for (int j = 0; j < arr.Length - 1 - i; ++j)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    flag = false;
                }
            }
            if (flag) { break; }
        }
    }

    public static void Selection(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; ++i)
        {
            int index = i;
            for (int j = i + 1; j < arr.Length; ++j)
            {
                if (arr[index] > arr[j])
                {
                    index = j;
                }
            }
            if (index != i)
            {
                (arr[i], arr[index]) = (arr[index], arr[i]);
            }
        }
    }
    public static void Insertion(int[] arr)
    {
        for (int i = 1; i < arr.Length; ++i)
        {
            int j = i - 1;
            int tmp = arr[i];
            while (j >= 0 && arr[j] > tmp)
            {
                arr[j + 1] = arr[j];
                --j;
            }
            arr[j + 1] = tmp;
        }
    }
    public static void MergSort(int[] arr, int left, int right)
    {
        if (left >= right) { return; }
        int mid = left + (right - left) / 2;
        MergSort(arr, left, mid);
        MergSort(arr, mid + 1, right);
        Merg(arr, left, right);
    }
    private static void Merg(int[] arr, int left, int right)
    {
        int mid = left + (right - left) / 2;
        int[] tmp = new int[right - left + 1];
        int i = left;
        int j = mid + 1;
        int k = 0;
        while (i <= mid && j <= right)
        {
            if (arr[i] < arr[j])
            {
                tmp[k++] = arr[i++];
            }
            else
            {
                tmp[k++] = arr[j++];
            }
        }
        while (i <= mid)
        {
            tmp[k++] = arr[i++];
        }
        while (j <= right)
        {
            tmp[k++] = arr[j++];
        }
        for (j = 0, i = left; j < tmp.Length; ++i, ++j)
        {
            arr[i] = tmp[j];
        }
    }
    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right) { return; }
        int pivot = Partition(arr, left, right);
        QuickSort(arr, left, pivot - 1);
        QuickSort(arr, pivot + 1, right);
    }
    /* Last pivot */
    /*private static int Partition(int[] arr, int left, int right)
    {
        int i = left;
        int j = right - 1;
        while (i <= j)
        {
            while (i <= j && arr[i] <= arr[right]) { ++i; }
            while (i <= j && arr[j] > arr[right]) { --j; }
            if (i < j)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
                ++i;
                --j;
            }
        }
        (arr[i], arr[right]) = (arr[right], arr[i]);
        return i;
    }*/
    /* First Pivot*/
    // private static int Partition(int[] arr, int left, int right)
    // {
    //     int i = left + 1;
    //     int j = right;
    //     while (i <= j)
    //     {
    //         while (i <= j && arr[i] <= arr[left]) { ++i; }
    //         while (i <= j && arr[j] > arr[left]) { --j; }
    //         if (i < j)
    //         {
    //             (arr[i], arr[j]) = (arr[j], arr[i]);
    //             ++i;
    //             --j;
    //         }
    //     }
    //     (arr[j], arr[left]) = (arr[left], arr[j]);
    //     return j;
    // }
    /* Rendom pivot */
    // private static int Partition(int[] arr, int left, int right)
    // {
    //     Random rand = new Random();
    //     int pivot = rand.Next(left, right + 1);
    //     (arr[right], arr[pivot]) = (arr[pivot], arr[right]);
    //     int i = left + 1;
    //     int j = right;
    //     while (i <= j)
    //     {
    //         while (i <= j && arr[i] <= arr[left]) { ++i; }
    //         while (i <= j && arr[j] > arr[left]) { --j; }
    //         if (i < j)
    //         {
    //             (arr[i], arr[j]) = (arr[j], arr[i]);
    //             ++i;
    //             --j;
    //         }
    //     }
    //     (arr[j], arr[left]) = (arr[left], arr[j]);
    //     return j;
    // }
    /* Median Partition */
    private static int Partition(int[] arr, int left, int right)
    {
        int mid = left + (right - left) / 2;
        if (arr[left] > arr[right])
        {
            (arr[left], arr[mid]) = (arr[mid], arr[left]);
        }
        if (arr[left] > arr[right])
        {
            (arr[left], arr[right]) = (arr[right], arr[left]);
        }
        if (arr[mid] > arr[right])
        {
            (arr[mid], arr[right]) = (arr[right], arr[mid]);
        }
        (arr[mid], arr[right]) = (arr[right], arr[mid]);

        int i = left;
        int j = right - 1;
        while (i <= j)
        {
            while (i <= j && arr[i] <= arr[right]) { ++i; }
            while (i <= j && arr[j] > arr[right]) { --j; }
            if (i < j)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
                ++i;
                --j;
            }
        }
        (arr[i], arr[right]) = (arr[right], arr[i]);
        return i;
    }
    public static void Counting(int[] arr)
    {
        int min = arr.Min();
        int max = arr.Max();

        int[] count = new int[max - min + 1];

        for (int i = 0; i < arr.Length; ++i)
        {
            ++count[arr[i] - min];
        }

        for (int i = 1; i < arr.Length; ++i)
        {
            count[i] += count[i - 1];
        }
        int[] res = new int[arr.Length];
        for (int i = 0; i < arr.Length; ++i)
        {
            int val = arr[i];
            int pos = count[val - min] - 1;
            res[pos] = val;
            --count[val - min];
        }

        for (int i = 0; i < arr.Length; ++i)
        {
            arr[i] = res[i];
        }
    }
    public static void HeapSort(int[] arr)
    {
        for (int i = arr.Length / 2 - 1; i >= 0; --i)
        {
            Heapify(arr, arr.Length, i);
        }

        for (int i = arr.Length - 1; i > 0; --i)
        {
            (arr[0], arr[i]) = (arr[i], arr[0]);
            Heapify(arr, i, 0);
        }
    }
    private static void Heapify(int[] arr, int n, int i)
    {
        int left = i * 2 + 1;
        int right = i * 2 + 2;
        int largest = i;

        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }
        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }
        if (largest != i)
        {
            (arr[largest], arr[i]) = (arr[i], arr[largest]);
            Heapify(arr, n, largest);
        }
    }
}