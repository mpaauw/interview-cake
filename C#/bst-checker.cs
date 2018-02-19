public static bool isBST(BinaryTreeNode root)
{
    if (root == null)
    {
        return true;
    }
    Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
    queue.Enqueue(root);
    while (queue.Count > 0)
    {
        BinaryTreeNode currentNode = queue.Dequeue();
        if (!isBSTNode(currentNode))
        {
            return false;
        }
        if (currentNode.Left != null)
        {
            queue.Enqueue(currentNode.Left);
        }
        if (currentNode.Right != null)
        {
            queue.Enqueue(currentNode.Right);
        }
    }
    return true; // gauntlet has been passed :)
}

private static bool isBSTNode(BinaryTreeNode node)
{
    if (node.Left != null)
    {
        if (node.Left.Value > node.Value)
        {
            return false;
        }
    }
    if (node.Right != null)
    {
        if (node.Right.Value < node.Value)
        {
            return false;
        }
    }
    return true;
}

public class BinaryTreeNode
{
    public int Value { get; }

    public BinaryTreeNode Left { get; set; }

    public BinaryTreeNode Right { get; set; }

    public BinaryTreeNode(int value)
    {
        Value = value;
    }

    public BinaryTreeNode InsertLeft(int leftValue)
    {
        Left = new BinaryTreeNode(leftValue);
        return Left;
    }

    public BinaryTreeNode InsertRight(int rightValue)
    {
        Right = new BinaryTreeNode(rightValue);
        return Right;
    }
}