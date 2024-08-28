// write a c# program to illustrate the concept of abstract class and method 

using System;

public abstract class Shape
{
    public double dim1, dim2;
    public Shape(double dim1, double dim2)
    {
        this.dim1 = dim1;
        this.dim2 = dim2;
    }
    public abstract double area();

}

public class Triangle : Shape
{
    public Triangle(double h, double b) : base(h, b)
    {

    }
    public override double area()
    {
        return 0.5 * dim1 * dim2;

    }
}

public class abstractEx
{
    public static void Main(string[] args)
    {
        Triangle t1 = new Triangle(4, 5);
        double a = t1.area();
        Console.WriteLine("Area of triangle is " + a);
        Console.ReadKey();
    }

}
