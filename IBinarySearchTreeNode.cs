namespace orthoganal_line_segment_intersection_search
{
    public interface IBinarySearchTreeNode<T>
    {
        IBinarySearchTreeNode<T> LeftNode { get; set; }
        IBinarySearchTreeNode<T> RightNode { get; set; }
        T Data { get; set; }
    }
}