public static bool balancedBinaryTree(BinaryTreeNode root)
{
    if (root == null)
    {
        return true;
    }

    // int depth = 0, minDepth = 0, maxDepth = 0;
    HashSet<int> depths = new HashSet<int>();

    // use DFS to traverse tree and record any leaf nodes and their depths:
    Stack<NodeDepthPair> stack = new Stack<NodeDepthPair>();
    stack.Push(new NodeDepthPair(root, 0));
    while (stack.Count > 0)
    {
        NodeDepthPair currentPair = stack.Pop();
        BinaryTreeNode currentNode = currentPair.node;
        int depth = currentPair.depth;

        // if current node is a leaf:
        if (currentNode.Left == null && currentNode.Right == null)
        {
            // if depth not already encountered:
            if (!depths.Contains(depth))
            {
                depths.Add(depth);

                // check for more than 2 depths (since each is unique, this means that there are more thyan a 1-depth discrepancy between two depths)
                // short circuit if true
                if (depths.Count > 2 || (depths.Count == 2 && Math.Abs(depths.ElementAt(0) - depths.ElementAt(1)) > 1))
                {
                    return false;
                }
            }
        }
        // otherwise, add applicable children to stack and continue to traverse tree:
        else
        {
            if (currentNode.Right != null)
            {
                stack.Push(new NodeDepthPair(currentNode.Right, depth + 1));
            }
            if (currentNode.Left != null)
            {
                stack.Push(new NodeDepthPair(currentNode.Left, depth + 1));
            }
        }
    }
    return true; // return true if the gauntlet has been cleared :)
}

public class NodeDepthPair
{
    public BinaryTreeNode node { get; set; }
    public int depth { get; set; }

    public NodeDepthPair(BinaryTreeNode node, int depth)
    {
        this.node = node;
        this.depth = depth;
    }
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