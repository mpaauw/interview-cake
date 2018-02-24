public LinkedListNode reverseList(LinkedListNode root)
{
    LinkedListNode current = root;
    LinkedListNode temp = null;
    LinkedListNode prev = null;
    while (current != null)
    {
        temp = current.next;
        current.next = prev;
        prev = current;
        current = temp;
    }
    return prev;
}

public class LinkedListNode
{
    public int value { get; set; }

    public LinkedListNode next { get; set; }

    public LinkedListNode(int value)
    {
        this.value = value;
    }
}
