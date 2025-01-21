class Circle : IShape
{
    int Radius { get; }
    public Circle(int radius)
    {
        this.Radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}