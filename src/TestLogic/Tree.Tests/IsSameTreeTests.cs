using QuestionCollection.DS;
using QuestionCollection.Questions;

namespace TestLogic.Tree.Tests;

public class IsSameTreeTests
    {
        [Fact]
        public void TestSameTrees()
        {
            // Tree 1:       Tree 2:
            //    1              1
            //   / \            / \
            //  2   3          2   3

            TreeNode tree1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode tree2 = new TreeNode(1, new TreeNode(2), new TreeNode(3));

            bool result = TreeQuestions.IsSameTree(tree1, tree2);

            Assert.True(result);
        }

        [Fact]
        public void TestDifferentTrees()
        {
            // Tree 1:       Tree 2:
            //    1              1
            //   / \            / \
            //  2   3          3   2

            TreeNode tree1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode tree2 = new TreeNode(1, new TreeNode(3), new TreeNode(2));

            bool result = TreeQuestions.IsSameTree(tree1, tree2);

            Assert.False(result);
        }

        [Fact]
        public void TestOneEmptyTree()
        {
            // Tree 1:       Tree 2:
            //    1            (empty)

            TreeNode tree1 = new TreeNode(1);
            TreeNode tree2 = null;

            bool result = TreeQuestions.IsSameTree(tree1, tree2);

            Assert.False(result);
        }

        [Fact]
        public void TestBothEmptyTrees()
        {
            // Tree 1:       Tree 2:
            //  (empty)       (empty)

            TreeNode tree1 = null;
            TreeNode tree2 = null;

            bool result = TreeQuestions.IsSameTree(tree1, tree2);

            Assert.True(result);
        }

        [Fact]
        public void TestOneNullTree()
        {
            // Tree 1:       Tree 2:
            //    1              1

            TreeNode tree1 = new TreeNode(1);
            TreeNode tree2 = null;

            bool result = TreeQuestions.IsSameTree(tree1, tree2);

            Assert.False(result);
        }

        [Fact]
        public void TestDifferentStructures()
        {
            // Tree 1:       Tree 2:
            //    1              1
            //   / \            / \
            //  2   3          2   3
            //                  |
            //                  4

            TreeNode tree1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode tree2 = new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4)));

            bool result = TreeQuestions.IsSameTree(tree1, tree2);

            Assert.False(result);
        }
    }