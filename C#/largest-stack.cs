public class MaxStack
{
    private Stack<int> stack = new Stack<int>();

    private Stack<int> maxStack = new Stack<int>();


    public void Push(int val)
    {
        this.stack.Push(val);
        if (this.maxStack.Count == 0 || val >= this.maxStack.Peek())
        {
            this.maxStack.Push(val);
        }
    }

    public int Pop()
    {
        int item = this.stack.Pop();
        if (item == this.maxStack.Peek())
        {
            maxStack.Pop();
        }
        return item;
    }

    public int GetMax(Stack<int> stack)
    {
        return this.maxStack.Peek();
    }
}