// Time: O(1), Space: O(1)
public Rectangle rectangularLove(Rectangle alpha, Rectangle beta)
{
    Overlap xOverlap = FindOverlap(alpha.LeftX, alpha.Width, beta.LeftX, beta.Width);
    Overlap yOverlap = FindOverlap(alpha.BottomY, alpha.Height, beta.BottomY, beta.Height);

    return new Rectangle(xOverlap.point, yOverlap.point, xOverlap.length, yOverlap.length);
}

private Overlap FindOverlap(int point1, int length1, int point2, int length2)
{
    int highestStartPoint = Math.Max(point1, point2);
    int lowestEndPoint = Math.Min(point1 + length1, point2 + length2);

    if (highestStartPoint >= lowestEndPoint)
    {
        throw new Exception("Rectangles do not overlap on any area.");
    }

    int overlapLength = lowestEndPoint - highestStartPoint;
    return new Overlap(highestStartPoint, overlapLength);
}

public class Overlap
{
    public int point;
    public int length;

    public Overlap(int point, int length)
    {
        this.point = point;
        this.length = length;
    }
}

public class Rectangle
{
    // Coordinates of bottom left corner
    public int LeftX { get; set; }
    public int BottomY { get; set; }

    // Dimensions
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle() { }

    public Rectangle(int leftX, int bottomY, int width, int height)
    {
        LeftX = leftX;
        BottomY = bottomY;
        Width = width;
        Height = height;
    }
}