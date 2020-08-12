public class Solution {
    public int[] SortArray(int[] nums) {
        QuickSort(nums, 0, nums.Length - 1);
        return nums;
    }
    
    public void QuickSort(int[] arr, int low, int high) {
        if (arr == null || arr.Length == 0)
        {
            return;
        }

        if (low >= high)
        {
            return;
        }

        // Get the pivot element from the middle of the list
        var middle = (low + high) / 2;
        var pivot = arr[middle];
        var i = low;
        var j = high;
        while (i <= j)
        {
            // Check until all values on left side array are lower than pivot
            while (arr[i] < pivot)
            {
                i++;
            }

            while (arr[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }

        // sort two sub arrays
        if (low < j)
        {
            QuickSort(arr, low ,j);
        }

        if (high > i)
        {
            QuickSort(arr, i, high);
        }
    }
}