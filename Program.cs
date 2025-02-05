using System.Drawing;
using geometryProject;

internal class Program
{
     static void Main(string[] args)
     {
        PointProgarm point1 = new PointProgarm(2, 3);
        PointProgarm point2 = new PointProgarm(3, 4);

        PointProgarm point3 = new PointProgarm(2, 3);
        PointProgarm point4 = new PointProgarm(3, 4);

        Line line1 = new Line(point1, point2);
        Line line2 = new Line(point3, point4);

        bool areEqual = line1.Equals(line2);
        Console.WriteLine($"Are the lines equal? {areEqual}");
        double length1 = line1.CalculateLength();
        Console.WriteLine($"Length of the Line 1 is = {length1}");

        double length2 = line2.CalculateLength();
        Console.WriteLine($"Length of the Line 2 is = {length2}");


        int comparisonResult = line1.CompareTo(line2);

        if (comparisonResult < 0)
            Console.WriteLine("Line 1 is shorter than Line 2.");
        else if (comparisonResult > 0)
            Console.WriteLine("Line 1 is longer than Line 2.");
        else
            Console.WriteLine("Line 1 is equal in length to Line 2.");
    }
}