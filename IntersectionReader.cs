using System.Collections.Generic;

namespace orthoganal_line_segment_intersection_search
{
    public class IntersectionReader
    {
        private readonly Queue<IEvent> eventsQueue = new Queue<IEvent>();
        
        public bool IsIntersection(IEnumerable<ISegment> segments)
        {
            foreach (var segment in segments)
            {
                if (segment.IsHorizontal)
                {
                    eventsQueue.Enqueue(new HorizontalInputEvent(segment.StartPointY));
                    eventsQueue.Enqueue(new HorizontalOutputEvent(segment.EndPointY));
                }
                else
                {
                    eventsQueue.Enqueue(new VerticalInputEvent(segment.StartPointY, segment.EndPointY));
                }
            }

            var bst = new BinaryTree();
            while (eventsQueue.Count != 0)
            {
                if (eventsQueue.Dequeue().IsIntersection(bst))
                    return true;
            }

            return false;
        }
    }
}