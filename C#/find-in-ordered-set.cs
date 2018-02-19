// Time: O(log n), Space: O(1)
public bool contains(int[] sortedArr, int value)
{
    return recursiveBinarySearch(sortedArr, value, 0, sortedArr.Length - 1) != -1;
}

private int recursiveBinarySearch(int[] arr, int value, int left, int right)
{
    if (right < left)
    {
        return -1; // element not found in array
    }
    int mid = (left + right) / 2;
    if (arr[mid] == value)
    {
        return mid;
    }
    if (value < arr[mid])
    {
        return recursiveBinarySearch(arr, value, left, mid - 1); // search left partition
    }
    else
    {
        return recursiveBinarySearch(arr, value, mid + 1, right); // search right partition
    }
}

private int iterativeBinarySearch(int[] arr, int value)
{
    int left = 0, right = arr.Length - 1;
    while (right > left)
    {
        int mid = (left + right) / 2;
        if (arr[mid] == value)
        {
            return mid;
        }
        if (value < arr[mid])
        {
            right = mid - 1; // search left partition
        }
        else 
        {
            left = mid + 1; // search right partition
        }
    }
    return -1; // element not found in array
}
