using QuestionCollection.DS;
using QuestionCollection.Questions;

namespace TestLogic.Tree.Tests
{
    public class MaximumDepthOfBinaryTreeTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3));

            /*
             * Tree structure:
             *      1
             *     / \
             *    2   3
             *   / \
             *  4   5
             */

            // Act
            int depth = MaximumDepthOfBinaryTree.Execute(root);

            // Assert
            Assert.Equal(3, depth);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3,
                    new TreeNode(6,
                        new TreeNode(7))));

            /*
             * Tree structure:
             *      1
             *     / \
             *    2   3
             *   /     \
             *  4       6
             *         /
             *        7
             */

            // Act
            int depth = MaximumDepthOfBinaryTree.Execute(root);

            // Assert
            Assert.Equal(4, depth);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            TreeNode? root = null;

            // Act
            int depth = MaximumDepthOfBinaryTree.Execute(root);

            // Assert
            Assert.Equal(0, depth);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            TreeNode root = new TreeNode(1);

            // Act
            int depth = MaximumDepthOfBinaryTree.Execute(root);

            // Assert
            Assert.Equal(1, depth);
        }

        [Fact]
        public void Test5()
        {
            // Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(3,
                        new TreeNode(4,
                            new TreeNode(5,
                                new TreeNode(6))))));

            /*
             * Tree structure:
             *      1
             *     /
             *    2
             *   /
             *  3
             * /
             * 4
             * /
             * 5
             * /
             * 6
             */

            // Act
            int depth = MaximumDepthOfBinaryTree.Execute(root);

            // Assert
            Assert.Equal(6, depth);
        }
    }
}
