// Efficiency: Time: O(n log n), Space: O(1)
public int findDuplicate(int[] arr) throws Exception {
    if(arr.length <= 1) {
        throw new Exception("Less than 2 elements in array!");
    }
    Arrays.sort(arr);
    int prev = arr[0];
    for(int i = 1; i < arr.length; i++) {
        int current = arr[i];
        if(prev == current) {
            return current;
        }
        prev = current;
    }
    throw new Exception("No duplicates found!");
}