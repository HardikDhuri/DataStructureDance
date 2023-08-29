using QuestionCollection.DS;
using QuestionCollection.Questions;

namespace TestLogic.Tree.Tests
{
    public class SymmetricTreeTests
    {
        //      1
        //     / \
        //    2   2
        //   / \ / \
        //  3  4 4  3
        [Fact]
        public void TestSymmetricTree()
        {
            TreeNode symmetricTree = new TreeNode(1,
                new TreeNode(2, new TreeNode(3), new TreeNode(4)),
                new TreeNode(2, new TreeNode(4), new TreeNode(3)));

            Assert.True(TreeQuestions.SymmetricTree(symmetricTree));
        }

        //      1
        //     / \
        //    2   2
        //     \   \
        //      3   3
        [Fact]
        public void TestNonSymmetricTree()
        {
            TreeNode nonSymmetricTree = new TreeNode(1,
                new TreeNode(2, null, new TreeNode(3)),
                new TreeNode(2, null, new TreeNode(3)));

            Assert.False(TreeQuestions.SymmetricTree(nonSymmetricTree));
        }

        // Empty tree
        [Fact]
        public void TestEmptyTree()
        {
            Assert.True(TreeQuestions.SymmetricTree(null));
        }

        // Single-node tree
        //   1
        [Fact]
        public void TestSingleNodeTree()
        {
            TreeNode singleNodeTree = new TreeNode(1);

            Assert.True(TreeQuestions.SymmetricTree(singleNodeTree));
        }

        //      1
        //     / \
        //    2   2
        //   / \ / \
        //  3  4 5  3
        [Fact]
        public void TestDifferentValues()
        {
            TreeNode differentValuesTree = new TreeNode(1,
                new TreeNode(2, new TreeNode(3), new TreeNode(4)),
                new TreeNode(2, new TreeNode(5), new TreeNode(3)));

            Assert.False(TreeQuestions.SymmetricTree(differentValuesTree));
        }
    }
}
