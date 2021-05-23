namespace orthoganal_line_segment_intersection_search
{
    public interface IBinarySearchTree<T>
    {
        bool Add(T value);
        IBinarySearchTreeNode<T> Find(T value);
        void Remove(T value);
    }
}