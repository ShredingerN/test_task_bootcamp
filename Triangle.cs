
class Triangle : Shape
{
    double SideA { get; }
    double SideB { get; }
    double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.SideA = sideA;
        this.SideB = sideB;
        this.SideC = sideC;
    }
    public override double CalculateArea()

    {
        if (IsValidTriangle(SideA, SideB, SideC))
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        return double.NaN;
    }

    private bool IsValidTriangle(double sideA, double sideB, double sideC)
    {
        return sideA + sideB > sideC &&
               sideA + sideC > sideB &&
               sideB + sideC > sideA;

    }
}