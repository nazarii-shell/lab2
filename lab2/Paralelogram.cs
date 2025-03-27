namespace lab2;

public class Paralelogram : HashTableElement

{
    private Vector v1;
    private Vector v2;
    private Vector v3;
    private Vector v4;

    public Paralelogram(Vector v1, Vector v2, Vector v3, Vector v4)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
    }

    public int CalculateArea()
    {
        var vectorA = new Vector { x = v2.x - v1.x, y = v2.y - v1.y };
        var vectorB = new Vector { x = v3.x - v1.x, y = v3.y - v1.y };

        int area = Math.Abs(vectorA.x * vectorB.y - vectorA.y * vectorB.x);
        return area;
    }

    public double CalculatePerimeter()
    {
        double s1 = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
        double s2 = Math.Sqrt(Math.Pow(v3.x - v1.x, 2) + Math.Pow(v3.y - v1.y, 2));

        return 2 * (s1 + s2);
    }

    public override String ToString()
    {
        // return $"V1: ({v1.x}, {v1.y}), V2: ({v2.x}, {v2.y}), V3: ({v3.x}, {v3.y}), V4: ({v4.x}, {v4.y})";
        return CalculatePerimeter().ToString();
    }

    public override int GetHashCode()
    {
        return (int) CalculatePerimeter();
    }
}