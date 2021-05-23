namespace orthoganal_line_segment_intersection_search
{
    public class HorizontalOutputEvent : IEvent<int>
    {
        private readonly int endPointY;
        
        public HorizontalOutputEvent(int endPointY) => this.endPointY = endPointY;

        public bool IsIntersection(IBinarySearchTree<int> binaryTree)
        {
            binaryTree.Add(endPointY);
            return false;
        }
    }
}