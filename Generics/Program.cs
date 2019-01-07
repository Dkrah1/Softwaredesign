using System;

namespace Generics
{
    public class TreeNode <T>
    {
        TreeNode <T> list = new TreeNode <T>();
        
        public TreeNode ()
        {
            var tree = new TreeNode <T>();
            
        }


        public TreeNode<T> CreateNode(T name)
        {
            return; 
        }

        public void AppendChild(TreeNode<T> childNode)
        {

        }

        public void RemoveChild(TreeNode<T> childNode)
        {

        }

        public void MoveChild(TreeNode<T> childNode)
        {

        }

        public void PrintTree(TreeNode<T> Node)
        {

        }

    }
}
