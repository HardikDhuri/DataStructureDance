using QuestionCollection.DS;

namespace QuestionCollection.Questions;

public static class SymmetricTree
{
    public static bool Execute(TreeNode? root)
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
    
}

/*
Try solving the question dividing it into different parts which in the sense means
using helper functions to check for underlying features of the question
*/