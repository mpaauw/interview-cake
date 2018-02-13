public int[] productOfOtherNumbers(int[] arr)
{
    int[] result = new int[arr.Length];

    // populate result array with 'products of every number before [i]' values:
    int runningProduct = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = runningProduct;
        runningProduct *= arr[i];
    }

    // modify result array with product of existing value and 'products of every number after [i]' values:
    runningProduct = 1;
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        result[i] *= runningProduct;
        runningProduct *= arr[i];
    }

    return result;
}