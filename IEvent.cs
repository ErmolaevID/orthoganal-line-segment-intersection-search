namespace orthoganal_line_segment_intersection_search
{
    public interface IEvent<T>
    {
        bool IsIntersection(IBinarySearchTree<T> binaryTree);
    }
}