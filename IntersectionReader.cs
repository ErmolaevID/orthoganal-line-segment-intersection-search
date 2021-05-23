using System.Collections.Generic;

namespace orthoganal_line_segment_intersection_search
{
    public class IntersectionReader
    {
        private readonly Queue<IEvent<int>> eventsQueue;
        private readonly IBinarySearchTree<int> binarySearchTree;
        
        public IntersectionReader(): this(new BinaryTree()) { }

        public IntersectionReader(IBinarySearchTree<int> binarySearchTree)
        {
            this.binarySearchTree = binarySearchTree;
            eventsQueue = new Queue<IEvent<int>>();
        }

        public bool IsIntersection(IEnumerable<ISegment> segments)
        {
            foreach (var segment in segments)
                if (segment.IsHorizontal)
                {
                    eventsQueue.Enqueue(new HorizontalInputEvent(segment.StartPointY));
                    eventsQueue.Enqueue(new HorizontalOutputEvent(segment.EndPointY));
                }
                else
                {
                    eventsQueue.Enqueue(new VerticalInputEvent(segment.StartPointY, segment.EndPointY));
                }

            while (eventsQueue.Count != 0)
                if (eventsQueue.Dequeue().IsIntersection(binarySearchTree))
                    return true;

            return false;
        }
    }
}