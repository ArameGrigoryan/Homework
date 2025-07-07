using System.Formats.Asn1;
using System.Formats.Tar;
using System.Runtime.InteropServices;

namespace Sourch;

public static class Sourch
{
    public static bool BS(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int mid = 0;
        while (left < right)
        {
            mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                return true;
            }
            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return false;
    }
    public static bool BS(int[] arr, int target, int left, int right)
    {
        if (left > right) { return false; }
        int mid = left + (right - left) / 2;
        if (arr[mid] == target) { return true; }
        if (arr[mid] < target)
        {
            return BS(arr, target, mid + 1, right);
        }
        else
        {
            return BS(arr, target, left, mid - 1);
        }
    }
    public static int LowerBound(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int mid = 0;
        while (left < right)
        {
            mid = left + (right - left) / 2;
            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }
    public static int LowerBound(int[] arr, int target, int left, int right)
    {
        if (left > right)
        {
            if (left == arr.Length) { return -1; }
            return (arr[left] == target) ? left : -1;
        }
        int mid = left + (right - left) / 2;
        if (arr[mid] < target)
        {
            return LowerBound(arr, target, mid + 1, right);
        }
        else
        {
            return LowerBound(arr, target, left, mid - 1);
        }
    }
    public static int UpperBound(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int mid = 0;

        while (left < right)
        {
            mid = left + (right - left) / 2;
            if (arr[mid] <= target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }
    public static int UpperBound(int[] arr, int target, int left, int right)
    {
        if (left > right)
        {
            if (left == 0) { return -1; }
            return (arr[left - 1] == target) ? left : -1;
        }
        int mid = left + (right - left) / 2;
        if (arr[mid] > target)
        {
            return UpperBound(arr, target, left, mid - 1);
        }
        else
        {
            return UpperBound(arr, target, mid + 1, right);
        }
    }
}
