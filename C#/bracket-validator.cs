public class BracketValidator
{
    private const char OPEN_PAREN = '(';
    private const char CLOSE_PAREN = ')';
    private const char OPEN_BRACE = '{';
    private const char CLOSE_BRACE = '}';
    private const char OPEN_BRACKET = '[';
    private const char CLOSE_BRACKET = ']';

    // Efficiency: Time: O(n), Space: O(n)
    public bool validate(string s)
    {

        // use a stack, will hold bbp (braces, brackets and parens)
        Stack<char> stack = new Stack<char>();

        // iterate through string, use stack to store opening bbp's
        // if closing bbp encountered, check it against stack's popped value:
        //  - if popped value from stack does not match closing bbp, return false
        for (int i = 0; i < s.Length; i++)
        {
            char c = s.ElementAt(i);
            if (c == OPEN_PAREN || C == OPEN_BRACE || c == OPEN_BRACKET)
            {
                stack.Push(c);
            }
            else if (c == CLOSE_PAREN)
            {
                if (stack.Pop() != OPEN_PAREN)
                {
                    return false;
                }
            }
            else if (c == CLOSE_BRACE)
            {
                if (stack.Pop() != OPEN_BRACE)
                {
                    return false;
                }
            }
            else if (c == CLOSE_BRACKET)
            {
                if (stack.Pop() != CLOSE_BRACKET)
                {
                    return false;
                }
            }
        }

        // when done iterating through string, if stack is not empty, return false
        if (stack.Count > 0)
        {
            return false;
        }

        // OTHERWISE: gauntlet survived...
        return true;
    }

}