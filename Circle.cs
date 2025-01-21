class Circle : Shape
{
    double Radius { get; }
    public Circle(double radius)
    {
        this.Radius = radius;
    }
    public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
}