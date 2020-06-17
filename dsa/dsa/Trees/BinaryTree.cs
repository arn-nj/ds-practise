using System;
namespace dsa.Trees
{
    public class BinaryTree
    {
        public TreeNode root;
        public BinaryTree()
        {
            root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            Console.WriteLine("Binary Tree");
        }

        //Recursive InOrderTraversal Binary Tree
        public void InorderTraverse(TreeNode root)
        {
            if (root == null) return;
            InorderTraverse(root.left);
            Console.Write(root.val+" ");
            InorderTraverse(root.right);

        }
        //Recursive PreOrderTraversal Binary Tree
        public void PreorderTraverse(TreeNode root)
        {
            if (root == null) return;
            Console.Write(root.val + " ");
            PreorderTraverse(root.left);
            PreorderTraverse(root.right);

        }

        //Recursive PostOrderTraversal Binary Tree
        public void PostorderTraverse(TreeNode root)
        {
            if (root == null) return;
            
            PostorderTraverse(root.left);
            PostorderTraverse(root.right);
            Console.Write(root.val + " ");

        }


    }
}
