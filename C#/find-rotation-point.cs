public int findRotationPoint(string[] words)
{
    if (words.Length <= 0)
    {
        throw new ArgumentException("Empty array.");
    }
    return iterativeBinarySearchStringArray(words);
}

private int iterativeBinarySearchStringArray(string[] words)
{
    string first = words[0];
    int left = 0, right = words.Length - 1;

    // pivot point found when left / right partition cross
    while (right >= left)
    {
        int mid = (left + right) / 2;
        if (string.Compare(words[mid], first, StringComparison.Ordinal) < 0)
        {
            left = mid + 1; // search left partition
        }
        else
        {
            right = mid - 1; // search right partition
        }
    }
    return right;
}