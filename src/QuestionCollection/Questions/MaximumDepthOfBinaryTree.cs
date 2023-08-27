using QuestionCollection.DS;

namespace QuestionCollection.Questions;

public static class MaximumDepthOfBinaryTree
{
    public static int Execute(TreeNode? root)
    {
        if (root == null) return 0;

        var left = root.Left != null ? Execute(root.Left) : 0;
        var right = root.Right != null ? Execute(root.Right) : 0;
        
        return 1 + Math.Max(left, right);
    }
}