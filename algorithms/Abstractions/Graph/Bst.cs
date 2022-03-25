using System;
using Abstractions.Graph.Interfaces;

namespace Abstractions.Graph
{
    public class Bst<T> : IBst<T>
    {
        
        private TreeNode<T> Head = null;

        public TreeNode<T> CurrentNode = null;

        public Bst()
        {
            CurrentNode = Head;
        }

        public bool Delete(TreeNode<T> node, T itemValue)
        {
            bool status = true; ;

            if(node == null)
            {
                status = false;
            }

            if(string.Compare(node.ItemValue.ToString(), itemValue.ToString()) < 0)
            {
                return Delete(node.RightNode, itemValue);
            }
            else if(string.Compare(node.ItemValue.ToString(), itemValue.ToString()) > 0)
            {
                return Delete(node.LeftNode, itemValue);
            }

            else if(node.LeftNode != null && node.RightNode != null)
            {

                TreeNode<T> replacementNode = FindMin(node.RightNode);

                Delete(replacementNode, itemValue);
            }
            else
            {
                var currentNnode = node;

                currentNnode = node.LeftNode != null ? node.LeftNode : node.RightNode;

                node = null;
                
            }
            return status;

        }

        public int Height(TreeNode<T> node)
        {
            if(node == null)
            {
                return 0;
            }
            
            return Math.Max(1 + Height(node.LeftNode), 1 + Height(node.RightNode));
            
        }

        public void InOrderTraverse(TreeNode<T> item)
        {
            InOrderTraverse(item.LeftNode);
            Console.WriteLine(item.ItemValue.ToString());
            InOrderTraverse(item.RightNode);
            
        }

        public void Insert(TreeNode<T> node, T item)
        {
            if(node == null)
            {
                node = new TreeNode<T>();
                node.ItemValue = item;
                return;
            }

            if(string.Compare(node.ItemValue.ToString(), item.ToString()) <= 0)
            {
                Insert(node.LeftNode, item);
            }
            else
            {
                Insert(node.RightNode, item);
            }
        }

        public void PostOrderTraverse(TreeNode<T> item)
        {
            throw new NotImplementedException();
        }

        public void PreOrderTraverse(TreeNode<T> item)
        {
            throw new NotImplementedException();
        }

        public TreeNode<T> Search(TreeNode<T> node, T itemValue)
        {
            if(node == null)
            {
                return null;
            }

            if(node.ItemValue.ToString() == itemValue.ToString())
            {
                return node;
            }
            else if(string.Compare(CurrentNode.ItemValue.ToString(), itemValue.ToString()) < 0)
            {
                return Search(node.RightNode, itemValue);
            }

            return Search(node.LeftNode, itemValue);
        }

        public TreeNode<T> FindMin(TreeNode<T> node)
        {
            if(node == null)
            {
                return null;
            }

            if (node.LeftNode == null)
            {

                return node.LeftNode;

            }
            else
            {                 
                return FindMin(node.LeftNode);
            }
        }
    }
}
