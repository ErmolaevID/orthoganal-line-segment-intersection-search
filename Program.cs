using System;

namespace orthoganal_line_segment_intersection_search
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = new IntersectionReader().IsIntersection(new[] {new StandardSegment(1, 5, 2, 2), new StandardSegment(3, 3, 5, 2)});
            Console.WriteLine(answer);
        }
    }
}
