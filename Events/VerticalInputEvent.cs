namespace orthoganal_line_segment_intersection_search
{
    public class VerticalInputEvent : IEvent
    {
        private readonly int startPointY;
        private readonly int endPointY;

        public VerticalInputEvent(int startPointY, int endPointY) =>
            (this.startPointY, this.endPointY) = (
                startPointY, endPointY);

        public bool IsIntersection(BinaryTree binaryTree)
        {
            for (var i = endPointY; i < startPointY; i++)
            {
                if (binaryTree.Find(i) == null) 
                    continue;
                binaryTree.Remove(i);
                return true;
            }
            return false;
        }
    }
}