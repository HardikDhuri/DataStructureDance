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
}