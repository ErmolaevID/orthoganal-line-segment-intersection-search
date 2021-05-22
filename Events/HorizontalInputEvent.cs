namespace orthoganal_line_segment_intersection_search
{
    public class HorizontalInputEvent : IEvent
    {
        private readonly int startPointY;
        
        public HorizontalInputEvent(int startPointY) => this.startPointY = startPointY;

        public bool IsIntersection(BinaryTree binaryTree)
        {
            binaryTree.Add(startPointY);
            return false;
        }
    }
}