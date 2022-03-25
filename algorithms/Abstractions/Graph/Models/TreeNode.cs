namespace Abstractions.Graph.Interfaces
{
    public class TreeNode<T>
    {
        public T ItemValue;
        public TreeNode<T> LeftNode;
        public TreeNode<T> RightNode;
    }
}