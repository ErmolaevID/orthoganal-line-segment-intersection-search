namespace orthoganal_line_segment_intersection_search
{
    public interface ISegment
    {
        int StartPointX { get; }
        int EndPointX { get; }
        int StartPointY { get; }
        int EndPointY { get; }
        bool IsHorizontal { get; }
        bool IsVertical { get; }
    }
}