using QuestionCollection.DS;
using QuestionCollection.Questions;

namespace TestLogic.Tree.Tests;

public class LevelOrderTraversalTests
{
    [Fact]
    public void Test_LevelOrderTraversal_BalancedTree()
    {
        TreeNode testTree = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(4),
                new TreeNode(5)),
            new TreeNode(3,
                new TreeNode(6),
                new TreeNode(7)));

        var result = TreeQuestions.LevelOrderTraversal(testTree);

        List<List<int>> expected = new List<List<int>>
        {
            new List<int> { 1 },
            new List<int> { 2, 3 },
            new List<int> { 4, 5, 6, 7 }
        };

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LevelOrderTraversal_UnbalancedTree()
    {
        TreeNode testTree = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(4)),
            new TreeNode(3));

        var result = TreeQuestions.LevelOrderTraversal(testTree);

        List<List<int>> expected = new List<List<int>>
        {
            new List<int> { 1 },
            new List<int> { 2, 3 },
            new List<int> { 4 }
        };

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LevelOrderTraversal_NullTree()
    {
        TreeNode testTree = null;

        var result = TreeQuestions.LevelOrderTraversal(testTree);

        List<List<int>> expected = new List<List<int>>();

        Assert.Equal(expected, result);
    }
}