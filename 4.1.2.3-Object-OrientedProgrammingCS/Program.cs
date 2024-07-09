namespace _4._1._2._3_Object_OrientedProgrammingCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            regularPolygon hexagon = new regularPolygon(6, 12);
            Console.WriteLine(hexagon.Area());
            Circle circle = new Circle(10);
            Console.WriteLine(circle.Area());
            Triangle triangle = new Triangle(10, 5);
            Console.WriteLine(triangle.Area());

        }
    }
}
abstract class Shape
{

    public abstract double Area();
}
class regularPolygon : Shape
{
    private int numSides;
    private int sideLength;
    public regularPolygon(int numSides, int sideLength)
    {
        this.numSides = numSides;
        this.sideLength = sideLength;
    }
    public override double Area()
    {
        return (numSides * sideLength * sideLength) / (4 * Math.Tan(Math.PI / numSides));
    }
}
class Circle : Shape
{
    private int radius;
    public Circle(int radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}
class Triangle : Shape
{
    private int baseLength;
    private int height;
    public Triangle(int baseLength, int height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }
    public override double Area()
    {
        return 0.5 * baseLength * height;
    }
}