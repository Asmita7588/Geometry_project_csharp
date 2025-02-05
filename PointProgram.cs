using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryProject
{
    class PointProgarm
    {
        public double x { get; }
        public double y { get; }

        public PointProgarm(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            PointProgarm other = (PointProgarm)obj;
            return x == other.x && y == other.y;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }
    }
    class Line : IComparable<Line>
    {
        public PointProgarm start { get; }
        public PointProgarm end { get; }
        public Line( PointProgarm start ,PointProgarm end)
        {
            this.start = start;
            this.end = end;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Line other = (Line)obj;
            return (start.Equals(other.start) && end.Equals(other.end)) ||
                   (start.Equals(other.end) && end.Equals(other.start));
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(start, end);
        }

        public double CalculateLength(){
            double dx = start.x - end.x;
            double dy = start.y - end.y;
            return Math.Sqrt(dx * dx + dy * dy);

        }

        public int CompareTo(Line other)
        {
            if (other == null) return 1;

            double thisLine = this.CalculateLength();
            double otherLine = other.CalculateLength();
            if (thisLine < otherLine) return -1;
            else if (thisLine > otherLine) return 1;
            else return 0;

        }
    }

}
