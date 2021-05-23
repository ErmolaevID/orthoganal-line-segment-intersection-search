namespace orthoganal_line_segment_intersection_search
{
    public class HorizontalInputEvent : IEvent<int>
    {
        private readonly int startPointY;
        
        public HorizontalInputEvent(int startPointY) => this.startPointY = startPointY;

        public bool IsIntersection(IBinarySearchTree<int> binaryTree)
        {
            binaryTree.Add(startPointY);
            return false;
        }
    }
}