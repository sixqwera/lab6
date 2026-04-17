using System;

namespace c__перывй_раз_
{
    public class LineSegment
    {
        private double x;
        private double y;

        public LineSegment(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public LineSegment(LineSegment other)
        {
            this.x = other.x;
            this.y = other.y;
        }

        public bool IsInside(double number)
        {
            double start = Math.Min(x, y);
            double end = Math.Max(x, y);

            return number >= start && number <= end;
        }

        public override string ToString()
        {
            return $"Отрезок: [{x}; {y}]";
        }
    }
}
