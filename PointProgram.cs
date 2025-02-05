using System;
using System.Collections.Generic;
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
    }
    class Line
    {
        public PointProgarm start { get; }
        public PointProgarm end { get; }
        public Line( PointProgarm start ,PointProgarm end)
        {
            this.start = start;
            this.end = end;
        }


        public double CalculateLength(){
            double dx = start.x - end.x;
            double dy = start.y - end.y;
            return Math.Sqrt(dx * dx + dy * dy);

        }

    }

}
