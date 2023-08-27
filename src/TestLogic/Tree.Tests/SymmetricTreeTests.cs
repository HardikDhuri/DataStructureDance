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

            Assert.True(SymmetricTree.Execute(symmetricTree));
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

            Assert.False(SymmetricTree.Execute(nonSymmetricTree));
        }

        // Empty tree
        [Fact]
        public void TestEmptyTree()
        {
            Assert.True(SymmetricTree.Execute(null));
        }

        // Single-node tree
        //   1
        [Fact]
        public void TestSingleNodeTree()
        {
            TreeNode singleNodeTree = new TreeNode(1);

            Assert.True(SymmetricTree.Execute(singleNodeTree));
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

            Assert.False(SymmetricTree.Execute(differentValuesTree));
        }
    }
}
