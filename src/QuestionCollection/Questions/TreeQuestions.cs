using QuestionCollection.DS;

namespace QuestionCollection.Questions;

public static class TreeQuestions
{
    public static int MaximumDepthOfBinaryTree(TreeNode? root)
    {
        if (root == null) return 0;

        var left = root.Left != null ? MaximumDepthOfBinaryTree(root.Left) : 0;
        var right = root.Right != null ? MaximumDepthOfBinaryTree(root.Right) : 0;
        
        return 1 + Math.Max(left, right);
    }
    
      public bool IsValidBST(TreeNode root) 
    {
        return Evaluate(root, long.MinValue, long.MaxValue);
    }

    private bool Evaluate(TreeNode node, long min, long max)
    {
        if (node == null)
        {
            return true;
        }

        return (
            node.val > min &&
            node.val < max &&
            Evaluate(node.left, min, node.val) &&
            Evaluate(node.right, node.val, max)
        );
    }
    public static bool SymmetricTree(TreeNode? root)
    {
        if (root == null) return true;

        return IsMirror(root.Left, root.Right);
    }

    private static bool IsMirror(TreeNode? left, TreeNode? right)
    {
        if (left == null && right == null)
        {
            return true;
        }

        if (left == null || right == null || left.Val != right.Val)
        {
            return false;
        }

        return IsMirror(left.Left, right.Right) && IsMirror(left.Right, right.Left);
    }

    public static bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if (p == null && q == null) return true; // When both are null

        if (p == null || q == null) return false; // When any one of them is null

        return IsSameTree(p.Left, q.Left) && IsSameTree(p.Right, q.Right) && p.Val == q.Val;
    }

    public static IList<IList<int>> LevelOrderTraversal(TreeNode root)
    {
        var result = new List<IList<int>>();
        LevelOrder(root, result);
        return result;
    }

    private static void LevelOrder(TreeNode? root, List<IList<int>> result)
    {
        if (root == null) return;

        var queue = new Queue<TreeNode?>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var subList = new List<int>();
            var sizeOfQueue = queue.Count;

            for (int i = 0; i < sizeOfQueue; i++)
            {
                var node = queue.Dequeue();
                subList.Add(node.Val);

                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);
            }

            result.Add(subList);
        }
    }
    
}