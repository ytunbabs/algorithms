using System;
namespace Abstractions.Graph.Interfaces
{
    public interface IBst<T>
    {
        void PostOrderTraverse(TreeNode<T> item);
        void InOrderTraverse(TreeNode<T> item);
        void PreOrderTraverse(TreeNode<T> item);
        int Height(TreeNode<T> node);
        void Insert(TreeNode<T> node, T item);
        bool Delete(TreeNode<T> node, T itemValue);
        TreeNode<T> Search(TreeNode<T> node, T itemValue);
    }
}
