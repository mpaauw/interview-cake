public static int getSecondLargest(BinaryTreeNode root)
    {
        if (root == null)
        {
            throw new ArgumentException("Empty BST.", nameof(root));
        }

        NodeParentPair largestNode = findLargest(null, root);
        if (largestNode.node.Left != null)
        {
            return findLargest(largestNode.parent, largestNode.node.Left).node.Value;
            
        }
        if (largestNode.node == root)
        {
            throw new Exception("Only one element in BST.");
        }
        return largestNode.parent.Value;
    }

    private static NodeParentPair findLargest(BinaryTreeNode parent, BinaryTreeNode node)
    {
        if (node.Right != null)
        {
            return findLargest(node, node.Right);
        }
        return new NodeParentPair(parent, node);
    }

public class NodeParentPair
    {
        public BinaryTreeNode node { get; set; }
        public BinaryTreeNode parent {get; set;}

    public NodeParentPair(BinaryTreeNode node, BinaryTreeNode parent)
    {
        this.node = node;
        this.parent = parent;
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