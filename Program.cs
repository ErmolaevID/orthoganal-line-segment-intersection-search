using System;

namespace orthoganal_line_segment_intersection_search
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new IntersectionReader();
            var case1 = new []
            {
                new StandardSegment(1, 5, 2, 2), 
                new StandardSegment(3, 3, 5, 2)
            };
            var case2 = new []
            {
                new StandardSegment(0, 5, 1, 1),
                new StandardSegment(1, 6, 2, 2),
                new StandardSegment(4, 4, 4, 0)
            };
            var case3 = new[]
            {
                new StandardSegment(1, 3, 1, 1),
                new StandardSegment(2, 4, 2, 2),
                new StandardSegment(4, 6, 1, 1),
            };
            Console.WriteLine(reader.IsIntersection(case1)); // true
            Console.WriteLine(reader.IsIntersection(case2)); // true
            Console.WriteLine(reader.IsIntersection(case3)); // false
        }
    }
}
