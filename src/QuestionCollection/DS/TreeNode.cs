namespace QuestionCollection.DS;

public class TreeNode {
     public int Val;
     public readonly TreeNode? Left;
     public readonly TreeNode? Right;

     public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) {
          this.Val = val;
          this.Left = left;
          this.Right = right;
      }
 }