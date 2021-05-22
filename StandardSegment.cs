namespace orthoganal_line_segment_intersection_search
{
    public class StandardSegment : ISegment
    {
        public int StartPointX { get; }
        public int EndPointX { get; }
        public int StartPointY { get; }
        public int EndPointY { get; }

        public bool IsHorizontal => StartPointY == EndPointY;

        public bool IsVertical => StartPointX == EndPointX;

        public StandardSegment(
            int startPointX, 
            int endPointX,
            int startPointY,
            int endPointY)
        {
            (StartPointX, EndPointX, StartPointY, EndPointY) = (
                startPointX, endPointX, startPointY, endPointY);
        }
    }
}