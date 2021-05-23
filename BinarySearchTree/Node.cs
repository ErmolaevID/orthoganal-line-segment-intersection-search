namespace orthoganal_line_segment_intersection_search
{
    public class Node : IBinarySearchTreeNode<int>
    {
        public IBinarySearchTreeNode<int> LeftNode { get; set; }
        public IBinarySearchTreeNode<int> RightNode { get; set; }
        public int Data { get; set; }
    }
}