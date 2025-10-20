using System;
using System.Drawing;

class Shape
{
    public string Color;
    public double Area;

    public Shape(string color)
    {
        Color = color;
        Area = default;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Color: {Color}, Area: {Area}");
    }
}

class Circle : Shape
{
    private double _radius;
    public double Radius { get
        {
            return _radius;
        } set {
            if (value>0)
            {
                _radius = value;
            }
        } }

    public Circle(double radius,string color):base(color)
    {
        Radius = radius;
        Area = Math.PI * Radius * Radius; 
    }
        
}
class Rectangle : Shape
{
    private double _length;
    public double Length { get
        {
            return _length;
        } set
        {
            if (value>0)
            {
                _length = value;
            }
        }
    }

    public Rectangle(double length,string color):base(color)
    {
        Length=length;
        Area = Length * Length;
    }

}

