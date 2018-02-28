// Time: O(n), Space: O(1)
public int MatchingParens(string s, int index)
{
    // edge case: throw exception if junk string or bad index supplied
    if (s == null || s.Length == 0 || index < 0)
    {
        throw new ArgumentException("Bad args!");
    }

    int openParen = 0;
    int result = 0; // variable to store indices of closing parens during string iteration

    if (s.ElementAt(index) != '(')
    {
        throw new ArgumentException("Supplied index does not refer to an opening paren!");
    }
    openParen++;

    for (int i = index + 1; i < s.Length; i++)
    {
        char c = s.ElementAt(i);
        if (c == '(')
        {
            openParen++;
        }
        else if (c == ')')
        {
            openParen--;
            result = i;
        }
        if (openParen == 0)
        {
            break;
        }
    }

    if (openParen > 0)
    {
        throw new ArgumentException("Unbalanced string supplied!");
    }

    return result;
}