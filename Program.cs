using System.Drawing;
using geometryProject;

internal class Program
{
     static void Main(string[] args)
     {
        PointProgarm point1 = new PointProgarm(2, 3);
        PointProgarm point2 = new PointProgarm(3, 4);

        Line line = new Line(point1, point2);

        double length = line.CalculateLength();
        Console.WriteLine($"Length of the Line is = {length}"); 
     }
}